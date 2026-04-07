const storageKeys = {
    chats: 'chatapp_chats',
    settings: 'chatapp_settings',
    activeChat: 'chatapp_active_chat',
};

const elements = {
    chatList: document.getElementById('chat-list'),
    newChatBtn: document.getElementById('new-chat-btn'),
    chatTitle: document.getElementById('chat-title'),
    chatSubtitle: document.getElementById('chat-subtitle'),
    messagesContainer: document.getElementById('messages-container'),
    messageInput: document.getElementById('message-input'),
    sendBtn: document.getElementById('send-btn'),
    fileInput: document.getElementById('file-input'),
    modeButtons: document.querySelectorAll('.mode-btn'),
    apiKeyInput: document.getElementById('api-key-input'),
    audioPlayer: document.getElementById('audio-player'),
};

const OPENAI_BASE = 'https://api.openai.com/v1';
let state = {
    chats: [],
    activeChatId: null,
    settings: {
        responseMode: 'text',
        openAIKey: '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',
    },
    loading: false,
};

function loadFromStorage() {
    const chats = localStorage.getItem(storageKeys.chats);
    const settings = localStorage.getItem(storageKeys.settings);
    const activeChatId = localStorage.getItem(storageKeys.activeChat);

    state.chats = chats ? JSON.parse(chats) : [];
    state.settings = settings ? { ...state.settings, ...JSON.parse(settings) } : state.settings;
    state.activeChatId = activeChatId || (state.chats[0] && state.chats[0].chatId) || null;

    if (!state.activeChatId) {
        createNewChat();
    }
}

function saveToStorage() {
    localStorage.setItem(storageKeys.chats, JSON.stringify(state.chats));
    localStorage.setItem(storageKeys.settings, JSON.stringify(state.settings));
    localStorage.setItem(storageKeys.activeChat, state.activeChatId);
}

function createNewChat() {
    const chatId = `chat_${Date.now()}`;
    const newChat = {
        chatId,
        title: 'New Chat',
        messages: [],
    };

    state.chats.unshift(newChat);
    state.activeChatId = chatId;
    saveToStorage();
    renderChatList();
    renderActiveChat();
}

function setActiveChat(chatId) {
    state.activeChatId = chatId;
    saveToStorage();
    renderChatList();
    renderActiveChat();
}

function getActiveChat() {
    return state.chats.find(chat => chat.chatId === state.activeChatId) || state.chats[0];
}

function updateChatTitle(chat) {
    const firstMessage = chat.messages.find(message => message.role === 'user');
    if (firstMessage) {
        chat.title = firstMessage.content.slice(0, 24) || 'Chat';
    } else {
        chat.title = 'New Chat';
    }
}

function addMessage(chatId, role, content, filePreview = null) {
    const chat = state.chats.find(item => item.chatId === chatId);
    if (!chat) return;
    chat.messages.push({ role, content, filePreview });
    if (role === 'user') {
        updateChatTitle(chat);
    }
    saveToStorage();
}

function renderChatList() {
    elements.chatList.innerHTML = '';
    state.chats.forEach(chat => {
        const item = document.createElement('div');
        item.className = `chat-item ${chat.chatId === state.activeChatId ? 'active' : ''}`;
        item.innerHTML = `
      <h3>${chat.title}</h3>
      <p>${chat.messages.length ? chat.messages[chat.messages.length - 1].content.slice(0, 30) : 'Start the conversation'}</p>
    `;
        item.addEventListener('click', () => setActiveChat(chat.chatId));
        elements.chatList.appendChild(item);
    });
}

function renderActiveChat() {
    const activeChat = getActiveChat();
    if (!activeChat) return;
    elements.chatTitle.textContent = activeChat.title || 'New Chat';
    elements.chatSubtitle.textContent = `Messages: ${activeChat.messages.length}`;
    elements.messagesContainer.innerHTML = '';

    activeChat.messages.forEach(message => {
        renderMessage(message);
    });

    if (state.loading) {
        renderTypingIndicator();
    }

    elements.messagesContainer.scrollTop = elements.messagesContainer.scrollHeight;
}

function renderMessage(message) {
    const row = document.createElement('div');
    row.className = `message-row ${message.role}`;

    const bubble = document.createElement('div');
    bubble.className = 'message-bubble';
    bubble.innerHTML = `<div>${message.content}</div>`;

    if (message.filePreview) {
        const preview = document.createElement('div');
        preview.className = 'message-preview';
        preview.innerHTML = `
      <div class="file-label">${message.filePreview.name}</div>
      ${message.filePreview.type.startsWith('image/') ? `<img src="${message.filePreview.url}" alt="Uploaded image" />` : `<iframe src="${message.filePreview.url}" title="File preview"></iframe>`}
    `;
        row.appendChild(preview);
    }

    row.appendChild(bubble);
    elements.messagesContainer.appendChild(row);
}

function renderTypingIndicator() {
    const row = document.createElement('div');
    row.className = 'message-row assistant';
    row.innerHTML = `
    <div class="message-bubble">AI is typing...<small>One moment</small></div>
  `;
    elements.messagesContainer.appendChild(row);
}

function normalizeIntent(message) {
    const text = message.toLowerCase();
    if (/generate|create|draw|make.*image|picture|photo|art/.test(text)) {
        return 'image_generation';
    }
    if (/analyze image|image analyze|inspect image|describe image|image description/.test(text)) {
        return 'image_analysis';
    }
    if (/analyze file|file analyze|read file|parse file/.test(text)) {
        return 'file_analysis';
    }
    return 'chat';
}

function createMockResponse(type, message, file) {
    if (type === 'image_generation') {
        return 'I would generate an image for you based on that prompt. The OpenAI image endpoint is ready.';
    }

    if (type === 'image_analysis') {
        return 'Received the image request. I would analyze the image contents and return the results.';
    }

    if (type === 'file_analysis') {
        return 'File analysis is ready. I would inspect the file and summarize the contents back to you.';
    }

    if (state.settings.responseMode === 'audio') {
        return 'This response mode is audio. OpenAI audio synthesis is prepared for playback.';
    }

    return `Assistant reply to: ${message}`;
}

function getOpenAIHeaders() {
    return {
        'Content-Type': 'application/json',
        Authorization: `Bearer ${state.settings.openAIKey}`,
    };
}

async function openAIChatCompletion({ message, type, fileBase64 }) {
    const bodyMessages = [
        { role: 'system', content: 'You are a helpful AI assistant.' },
        { role: 'user', content: message },
    ];

    if (type === 'file_analysis' && fileBase64) {
        bodyMessages.push({
            role: 'user',
            content: `Analyze the attached file in base64 format and summarize what it contains: ${fileBase64}`,
        });
    }

    if (type === 'image_analysis' && fileBase64) {
        bodyMessages.push({
            role: 'user',
            content: `Analyze the attached image encoded as base64 and describe its contents: ${fileBase64}`,
        });
    }

    const response = await fetch(`${OPENAI_BASE}/chat/completions`, {
        method: 'POST',
        headers: getOpenAIHeaders(),
        body: JSON.stringify({
            model: 'gpt-4o-mini',
            messages: bodyMessages,
            temperature: 0.8,
            max_tokens: 950,
        }),
    });

    if (!response.ok) {
        const error = await response.json().catch(() => null);
        throw new Error(error?.error?.message || 'OpenAI chat request failed');
    }

    const data = await response.json();
    return data.choices[0]?.message?.content?.trim() || '';
}

async function openAIImageGeneration(prompt) {
    const response = await fetch(`${OPENAI_BASE}/images/generations`, {
        method: 'POST',
        headers: getOpenAIHeaders(),
        body: JSON.stringify({
            model: 'gpt-image-1-mini',
            prompt,
            n: 1,
            size: '1024x1024',
        }),
    });

    if (!response.ok) {
        const error = await response.json().catch(() => null);
        throw new Error(error?.error?.message || 'OpenAI image request failed');
    }

    const data = await response.json();
    const b64 = data.data?.[0]?.b64_json;
    const url = data.data?.[0]?.url;
    if (!b64 && !url) {
        throw new Error('OpenAI image response missing image data');
    }

    const preview = {
        name: 'Generated Image',
        type: 'image/png',
        url: b64 ? `data:image/png;base64,${b64}` : url,
    };

    return {
        content: `Image generated from prompt: ${prompt}`,
        filePreview: preview,
    };
}

async function openAIAudioSpeech(text) {
    const response = await fetch(`${OPENAI_BASE}/audio/speech`, {
        method: 'POST',
        headers: {
            Authorization: `Bearer ${state.settings.openAIKey}`,
            'Content-Type': 'application/json',
            Accept: 'audio/mpeg',
        },
        body: JSON.stringify({
            model: 'tts-1',
            voice: 'alloy',
            input: text,
        }),
    });

    if (!response.ok) {
        const error = await response.json().catch(() => null);
        throw new Error(error?.error?.message || 'OpenAI audio request failed');
    }

    const buffer = await response.arrayBuffer();
    const blob = new Blob([buffer], { type: 'audio/mpeg' });
    return URL.createObjectURL(blob);
}

async function callOpenAI({ message, chatId, type, file: fileBase64 }) {
    if (!state.settings.openAIKey) {
        return { success: false, content: 'Please enter an OpenAI API key in settings to enable live responses.' };
    }

    try {
        if (type === 'image_generation') {
            const generated = await openAIImageGeneration(message);
            return { success: true, content: generated.content, filePreview: generated.filePreview };
        }

        const textResponse = await openAIChatCompletion({ message, type, fileBase64 });
        if (state.settings.responseMode === 'audio' && textResponse) {
            const audioUrl = await openAIAudioSpeech(textResponse);
            return { success: true, content: textResponse, audioUrl };
        }

        return { success: true, content: textResponse };
    } catch (error) {
        return { success: false, content: error.message || createMockResponse(type, message, fileBase64) };
    }
}

async function handleSend(message, filePreview = null, fileBase64 = null, intent = null) {
    if (!message && !filePreview) return;

    const activeChat = getActiveChat();
    const type = intent || normalizeIntent(message || '');
    addMessage(activeChat.chatId, 'user', message || 'Uploaded file request', filePreview);
    state.loading = true;
    renderActiveChat();
    elements.messageInput.value = '';

    const response = await callOpenAI({
        message,
        chatId: activeChat.chatId,
        type,
        file: fileBase64,
    });

    state.loading = false;

    if (!response.success) {
        addMessage(activeChat.chatId, 'assistant', response.content);
    } else {
        const assistantText = response.content || createMockResponse(type, message, filePreview);
        addMessage(activeChat.chatId, 'assistant', assistantText, response.filePreview || null);

        if (response.audioUrl) {
            playAudio(response.audioUrl);
        }
    }

    renderActiveChat();
    elements.messagesContainer.scrollTop = elements.messagesContainer.scrollHeight;
}

function playAudio(audioUrl) {
    elements.audioPlayer.src = audioUrl;
    elements.audioPlayer.hidden = false;
    elements.audioPlayer.play().catch(() => {
        console.warn('Audio playback failed.');
    });
}

function handleFileUpload(files) {
    const file = files[0];
    if (!file) return;

    const reader = new FileReader();
    reader.onload = async () => {
        const fileBase64 = reader.result.split(',')[1];
        const previewUrl = reader.result;
        const preview = {
            name: file.name,
            type: file.type,
            url: previewUrl,
        };

        const intent = file.type.startsWith('image/') ? 'image_analysis' : 'file_analysis';
        await handleSend(`Analyze uploaded ${file.type.split('/')[0]} file`, preview, fileBase64, intent);
    };
    reader.readAsDataURL(file);
}

function bindEvents() {
    elements.newChatBtn.addEventListener('click', createNewChat);

    elements.sendBtn.addEventListener('click', () => {
        const message = elements.messageInput.value.trim();
        handleSend(message);
    });

    elements.messageInput.addEventListener('keydown', event => {
        if (event.key === 'Enter' && !event.shiftKey) {
            event.preventDefault();
            const message = elements.messageInput.value.trim();
            handleSend(message);
        }
    });

    elements.fileInput.addEventListener('change', event => {
        handleFileUpload(event.target.files);
        elements.fileInput.value = '';
    });

    elements.modeButtons.forEach(btn => {
        btn.addEventListener('click', () => {
            elements.modeButtons.forEach(button => button.classList.remove('active'));
            btn.classList.add('active');
            state.settings.responseMode = btn.dataset.mode;
            saveToStorage();
        });
    });

    elements.apiKeyInput.addEventListener('input', event => {
        state.settings.openAIKey = event.target.value.trim();
        saveToStorage();
    });
}

function initializeUI() {
    loadFromStorage();
    renderChatList();
    renderActiveChat();
    bindEvents();

    elements.modeButtons.forEach(button => {
        if (button.dataset.mode === state.settings.responseMode) {
            button.classList.add('active');
        }
    });

    elements.apiKeyInput.value = state.settings.openAIKey || '';
}

initializeUI();
