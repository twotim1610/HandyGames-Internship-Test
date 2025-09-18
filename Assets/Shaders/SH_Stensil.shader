Shader "Renderers/SH_Stensil"
{
    Properties
    {
        [IntRange] _StencilID ("Stencil ID", Range(0,10)) = 0
    }

    HLSLINCLUDE

    ENDHLSL

    SubShader
    {
        Tags
        {
            "RenderType" = "Opaque"
            "RenderPipeline" = "HDRenderPipeline"
            "Queue" = "Geometry"
        }
        Pass
        {
             ZWrite Off
        }
    }
}
