#pragma once

#include "../Face/3rd_party/seetaface2/CStruct.h"

using namespace System;
using namespace System::Collections::Generic;
using namespace System::Drawing;
using namespace System::Drawing::Imaging;

namespace Face
{
	public ref class Utils
	{
	public:
		Utils();

	public:
		static unsigned char* Bitmap2Data(Bitmap^ bmp);
		static Bitmap^ Data2Bitmap(int width, int height, unsigned char* data);
		static SeetaImageData Bitmap2SeetaImageData(Bitmap^ bmp);
		static SeetaPointF PointF2SeetaPointF(PointF^ p);
		static SeetaRect Rectangle2SeetaRect(Rectangle^ rect);
	};
}

