#include "stdafx.h"
#include "Utils.h"

namespace Face
{
	Utils::Utils()
	{
	}

	unsigned char* Utils::Bitmap2Data(Bitmap^ bmp)
	{
		System::Drawing::Rectangle rect = System::Drawing::Rectangle(0, 0, bmp->Width, bmp->Height);
		BitmapData^ bmpData = bmp->LockBits(rect, System::Drawing::Imaging::ImageLockMode::ReadWrite, bmp->PixelFormat);
		unsigned char* pData = (unsigned char*)bmpData->Scan0.ToPointer();

		bmp->UnlockBits(bmpData);

		return pData;
	}

	Bitmap^ Utils::Data2Bitmap(int width, int height, unsigned char* data)
	{
		System::Drawing::Bitmap^ bmp = gcnew Bitmap(width,height,
													width,
													System::Drawing::Imaging::PixelFormat::Format8bppIndexed,
													(System::IntPtr)data);

		return bmp;
	}


	SeetaImageData Utils::Bitmap2SeetaImageData(Bitmap^ bmp)
	{
		SeetaImageData seetaImageData;
		seetaImageData.width = bmp->Width;
		seetaImageData.height = bmp->Height;
		seetaImageData.channels = bmp->PixelFormat == PixelFormat::Format8bppIndexed ? 1 : 3;
		seetaImageData.data = Utils::Bitmap2Data(bmp);

		return seetaImageData;
	}
	
	SeetaPointF Utils::PointF2SeetaPointF(PointF^ p)
	{
		SeetaPointF seetaPoint;
		seetaPoint.x = p->X;
		seetaPoint.y = p->Y;

		return seetaPoint;
	}

	SeetaRect Utils::Rectangle2SeetaRect(Rectangle^ rect)
	{
		SeetaRect seetaRect;
		seetaRect.x = rect->X;
		seetaRect.y = rect->Y;
		seetaRect.width = rect->Width;
		seetaRect.height = rect->Height;

		return seetaRect;
	}

}