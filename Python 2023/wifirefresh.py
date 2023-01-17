import subprocess


def refresh_wifi_ssid_list():
    # Run the command to refresh the WiFi SSID list
    subprocess.run(["netsh", "wlan", "refresh"])


refresh_wifi_ssid_list()
