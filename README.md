# TesteAR
Teste Prático de Aplicação em Realidade Aumentada utilizando Unity & Vuforia

Inicialmente, optei por criar um sistema solar reduzido, começando pela busca das texturas que iria utilizar.

Depois de encontrar as texturas, fui para o Blender. Utilizei esferas UV para modelar os planetas, então a fase de modelagem foi bem simples. Para manter o limite de 5000 faces, evitei subdivisões e usei o "shade smooth" para suavizar as quinas.

Na animação das órbitas, usei uma curva (Curve) com um constrain "Follow Path". Variando os intervalos, consegui simular velocidades diferentes de acordo com a distância do planeta em relação ao Sol.

Após finalizar, fiz o bake da animação e exportei o arquivo em formato FBX.

No Unity, configurei o Vuforia, importei os pacotes necessários, e adicionei a AR Camera e meu Target. Em seguida, importei o modelo e configurei os materiais e as animações.

Criei também um script que exibe um quadro com informações sobre o Sol, baseado na distância da câmera em relação a ele.

Como não tenho um dispositivo Android disponível, precisei dessa alternativa de interação para usar uma webcam. Embora tenha pesquisado e tentado algumas compilações para iPhone, descobri que é necessário um Mac para finalizar a tarefa.

