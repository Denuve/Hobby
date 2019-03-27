namespace MarioGame
{
    internal enum blocks
    {
        [MyAttribute("land")]
        land,

        [MyAttribute("brick")]
        brick,

        [MyAttribute("questionMark ")]
        questionMark,

        [MyAttribute("invincible")]
        invincible,

        [MyAttribute("pipe1")]
        pipe1,

        [MyAttribute("pipe2")]
        pipe2,

        [MyAttribute("pipe3")]
        pipe3,

        [MyAttribute("pipe4")]
        pipe4,

        [MyAttribute("flag1")]
        flag1,

        [MyAttribute("flag2")]
        flag2
    }
    internal enum enemies
    {
        [MyAttribute("goomba")]
        goomba,

        [MyAttribute("turtle")]
        turtle
    }
    internal enum bonus
    {
        [MyAttribute("mushroom")]
        mushroom,

        [MyAttribute("flower")]
        flower,

        [MyAttribute("star")]
        star,

        [MyAttribute("oneUp")]
        oneUp
    }
}
