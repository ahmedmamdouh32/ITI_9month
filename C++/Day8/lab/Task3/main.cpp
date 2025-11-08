//-----------------------------------------------------------------------------------------------------------
#include <BLEDevice.h>
#include <BLEServer.h>
#include <BLEUtils.h>
#include <BLE2902.h>
BLEServer *pServer = NULL;
BLECharacteristic *pTxCharacteristic;
bool deviceConnected = false;
bool oldDeviceConnected = false;
uint8_t txValue = 0;
bool first_connect = true;
//-----------------------------------------------------------------------------------------------------------
#define BluetoothPIN 12
#define BluetoothPIN_PressTime 1200
bool BluetoothPIN_state;
bool button_pressed = false;
long long BluetoothPIN_Start_Time;
bool BluetoothPIN_timer_stop = false;
long long BluetoothPIN_Press_Duration = 0;
bool first_time = true;
//-----------------------------------------------------------------------------------------------------------
#include "esp_mac.h"


// See the following for generating UUIDs:
// https://www.uuidgenerator.net/

#define SERVICE_UUID           "6E400001-B5A3-F393-E0A9-E50E24DCCA9E"  // UART service UUID
#define CHARACTERISTIC_UUID_RX "6E400002-B5A3-F393-E0A9-E50E24DCCA9E"
#define CHARACTERISTIC_UUID_TX "6E400003-B5A3-F393-E0A9-E50E24DCCA9E"

class MyServerCallbacks : public BLEServerCallbacks {
  void onConnect(BLEServer *pServer) {
    deviceConnected = true;
	Serial.println("Device Connected Successfully");
  };

  void onDisconnect(BLEServer *pServer) {
    deviceConnected = false;
	Serial.println("Device Disconnected !!!");
  }
};
class MyCallbacks : public BLECharacteristicCallbacks {
  void onWrite(BLECharacteristic *pCharacteristic) {
  String rxValue = pCharacteristic->getValue().c_str();

    if (rxValue.length() > 0) {
        Serial.println(rxValue);  //send to the Laptop
        Serial2.print(rxValue);  //send to stm32
    }
  }
};

void setup() {
  pinMode(BluetoothPIN,INPUT_PULLUP);
  Serial.begin(115200);

  // Create the BLE Device
  BLEDevice::init("ESP32 BLE Device");

  // Create the BLE Server
  pServer = BLEDevice::createServer();
  pServer->setCallbacks(new MyServerCallbacks());

  // Create the BLE Service
  BLEService *pService = pServer->createService(SERVICE_UUID);

  BLECharacteristic *pRxCharacteristic = pService->createCharacteristic(CHARACTERISTIC_UUID_RX, BLECharacteristic::PROPERTY_WRITE);

  pRxCharacteristic->setCallbacks(new MyCallbacks());

  // Start the service
  pService->start();

  // Start advertising
  pServer->getAdvertising()->start();
  Serial.println("Waiting a client connection to notify...");


  Serial2.begin(9600, SERIAL_8N1, 16, 17); // RX = 16 (R2), TX = 17 (T2)
  Serial.println("UART2 is ready!");

  Print_MAC_Address();


}

void loop() {  
  if (deviceConnected) {
    if(first_connect)
    {
      Serial.println("device connected");
      first_connect = false;
    }

    delay(10);  // bluetooth stack will go into congestion, if too many packets are sent
  }

  // disconnecting
  if (!deviceConnected && oldDeviceConnected){
    first_connect = true;
    delay(500);                   // give the bluetooth stack the chance to get things ready
    pServer->startAdvertising();  // restart advertising
    Serial.println("start advertising");
    oldDeviceConnected = deviceConnected;
  }
  // connecting
  if (deviceConnected && !oldDeviceConnected) {
    // do stuff here on connecting
    oldDeviceConnected = deviceConnected;
  }
}

void Print_MAC_Address(){
  uint8_t mac[6] = {0};
  esp_err_t ret = ESP_OK;
  ret = esp_read_mac(mac, ESP_MAC_EFUSE_FACTORY);
  if (ret != ESP_OK){
    Serial.printf("Failed to get base MAC address from EFUSE BLK0. (%s)", esp_err_to_name(ret));
  }
  else{
    Serial.printf("MAC %02X%02X%02X%02X%02X%02X\n", mac[0], mac[1], mac[2], mac[3], mac[4], mac[5]+2);
  }
}