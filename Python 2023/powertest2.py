import subprocess
import time

status = 0  # OFF


def get_ssids():
    # Run the command 'netsh wlan show networks mode=bssid' and get the output
    output = subprocess.check_output("netsh wlan show networks mode=bssid")

    # Convert the output to a string
    output = output.decode("utf-8")

    # Split the output by newline
    output = output.split("\n")

    # print(output)

    # Initialize an empty list to store the SSIDs
    ssids = []

    # Loop through the output
    for line in output:
        # Check if the line starts with 'SSID'
        if line.startswith("SSID"):
            # Split the line by colon
            line = line.split(":")
            # print(line)
            # Get the SSID name
            ssid = line[1].strip()

            # Append the SSID to the list
            ssids.append(ssid)

    # return the list of SSIDs
    return ssids


# Print the list of SSIDs
def checkPower():
    current_status = 0
    global status
    ssids2 = get_ssids()
    print(ssids2)

    for ssid in ssids2:
        if ssid == 'bluephoenix':
            # "CLASS-1D12"
            # print("Power is ON")
            current_status = 1

    print('cs', current_status)
    if status != current_status:
        status = current_status
        if status == 1:
            print('Power is ON')
        else:
            print('Power is OFF')

    print('status', status)


while 1:
    subprocess.run("netsh interface set interface name=Wi-Fi admin=disabled")
    subprocess.run("netsh interface set interface name=Wi-Fi admin=enabled")
    time.sleep(10)
    checkPower()
