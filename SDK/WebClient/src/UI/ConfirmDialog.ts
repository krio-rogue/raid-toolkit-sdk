const rtkLogo = `data:image/png;base64,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`;

let hasGrantedAccess = localStorage.getItem('rtk:granted') == 'true';
export function showConnectDialog(): Promise<void> {
  if (hasGrantedAccess) {
    return Promise.resolve();
  }
  return new Promise((resolve, reject) => {
    const overlayRoot = document.createElement('div');
    overlayRoot.setAttribute(
      'style',
      `background-color: rgba(0, 0, 0, 0.3); 
-webkit-backdrop-filter: blur(10px);
backdrop-filter: blur(10px);
top: 0px;
left: 0px;
right: 0px;
bottom: 0px;
position: fixed;
display: flex;
justify-content: center;
align-items: center;
 `
    );

    const dialogContainer = document.createElement('div');
    dialogContainer.setAttribute(
      'style',
      `max-width: 50%;
padding: 25px;
background-color: rgba(0, 0, 0, 0.8);
border-radius: 10px;
display: flex;
gap: 20px;
flex-direction: column;
align-items: center;
`
    );

    const logoImg = document.createElement('img');
    logoImg.src = rtkLogo;
    logoImg.setAttribute('style', `max-width: 75%;`);
    dialogContainer.appendChild(logoImg);

    const text = document.createElement('div');
    text.style.color = '#e8bc95';
    text.style.textAlign = 'center';
    text.innerHTML = `
<p>This website wishes to connect to Raid Toolkit on your computer. If you don't have it installed, you can get it <a href="https://github.com/raid-toolkit/raid-toolkit-sdk" target="_blank">here</a>.</p>
<p>By using this feature, you agree to have your data accessed by the website and routed through the RTK servers*.
  Only continue if you trust the author of this application/website.</p>
<p>By clicking agree, you will see a prompt to open a link handled by <strong>Raid.Service</strong>. After opening it, the RaidToolkit service running on your computer will prompt you for access to be granted to this website.</p>
<p style="font-size: smaller; opacity: 0.5;"><em>* the RTK servers do not persist or retain your data in any way, however it does not guarantee consumers of the data will not do so.</em></p>`;
    dialogContainer.appendChild(text);

    const acceptButton = document.createElement('span');
    acceptButton.setAttribute(
      'style',
      `display: inline-block;
color: white;
border-radius: 5px;
background-color: rgba(92, 112, 128, .3);
padding: 4px 10px;
cursor: pointer;`
    );
    acceptButton.innerText = '✔️ Yeah, gimme that sweet data!';
    const cancelButton = document.createElement('span');
    cancelButton.setAttribute(
      'style',
      `display: inline-block;
color: white;
border-radius: 5px;
background-color: rgba(112, 32, 21, 0.87);
padding: 4px 10px;
cursor: pointer;`
    );
    cancelButton.innerText = '❌ Oh hell no.';

    acceptButton.addEventListener('click', () => {
      document.body.removeChild(overlayRoot);
      hasGrantedAccess = true;
      localStorage.setItem('rtk:granted', 'true');
      resolve();
    });
    cancelButton.addEventListener('click', () => {
      document.body.removeChild(overlayRoot);
      localStorage.removeItem('rtk:granted');
      hasGrantedAccess = false;
      reject(new Error('User refused access'));
    });

    const footer = document.createElement('div');
    footer.setAttribute('style', `display: flex; gap: 20px; `);
    footer.appendChild(acceptButton);
    footer.appendChild(cancelButton);
    dialogContainer.appendChild(footer);

    overlayRoot.appendChild(dialogContainer);
    document.body.appendChild(overlayRoot);
  });
}