**FlowLayoutGroup**

Flow Layout Group is evolved version of Grid Layout Group for Unity UI. It allows to build Tag like element group.

**How to Use**

1. Attach this script to your panel just like you would use other layout groups like GridViewLayout
2. Add UI element (Buttons, Images etc) as child of Panel.
3. Add `ContentSizeFitter` component to children and set `Horizontal Fit` and `Vertical Fit` properties to **Preferred Size** 
4. Add `Layout Element` component to child and set `Preferred Width` and `Preferred Height` values. These values will control size of UI Element. 
5. Add as many elements as you want and apply same procedure to get desired size.
