import NetworkManager

for device in NetworkManager.NetworkManager.GetDevices():
    if device.DeviceType == NetworkManager.NM_DEVICE_TYPE_WIFI:
        for ap in device.GetAccessPoints():
            if ap.Ssid == 'greenhackers':
                print('SSID "greenhackers" is available')
