# AvatarLoger
Log Avatar to file and Webhook

# Config File
File is located in AvatarLog folder (Generates on first run)

CanPostFriendsAvatar set true or false if you want to allow posting to Webhook of your friends Avatars.
CanPostSelfAvatar set true or false if you want to allow posting to Webhook of your own Avatars.

Using a single Webhook URL:
```json
{
  "PublicWebhook": [
	"My Webhook url for public avatars"
  ],
  "PrivateWebhook": [
	"My Webhook url for private avatars"
  ],
  "BotName": "Bot name",
  "AvatarURL": "Webhook Avatar image url",
  "CanPostFriendsAvatar": false,
  "CanPostSelfAvatar": false
}
```

Using multiple Webhook URLs:
```json
{
  "PublicWebhook": [
	"My first Webhook url for public avatars",
	"My second Webhook url for public avatars"
  ],
  "PrivateWebhook": [
	"My first Webhook url for private avatars",
	"My second Webhook url for private avatars"
  ],
  "BotName": "Bot name",
  "AvatarURL": "Webhook Avatar image url",
  "CanPostFriendsAvatar": false,
  "CanPostSelfAvatar": false
}
```


# preview

Public Avatar

![webhook1](https://i.imgur.com/ecJZyYN.png)

Private Avatar

![Webhook2](https://i.imgur.com/WyXJ8rZ.png)

