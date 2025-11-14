using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F51F125 - .
/// </summary>
public class F51F125 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// QI51FFID.
        /// </summary>
        public const string QI51FFID = "QI51FFID";

        /// <summary>
        /// QI51FFHID.
        /// </summary>
        public const string QI51FFHID = "QI51FFHID";

        /// <summary>
        /// QIAID.
        /// </summary>
        public const string QIAID = "QIAID";

        /// <summary>
        /// QIMCU.
        /// </summary>
        public const string QIMCU = "QIMCU";

        /// <summary>
        /// QISUB.
        /// </summary>
        public const string QISUB = "QISUB";

        /// <summary>
        /// QIOBJ.
        /// </summary>
        public const string QIOBJ = "QIOBJ";

        /// <summary>
        /// QICCT.
        /// </summary>
        public const string QICCT = "QICCT";

        /// <summary>
        /// QI51FMOCF.
        /// </summary>
        public const string QI51FMOCF = "QI51FMOCF";

        /// <summary>
        /// QI51FAA01.
        /// </summary>
        public const string QI51FAA01 = "QI51FAA01";

        /// <summary>
        /// QI51FAU01.
        /// </summary>
        public const string QI51FAU01 = "QI51FAU01";

        /// <summary>
        /// QI51FPA01.
        /// </summary>
        public const string QI51FPA01 = "QI51FPA01";

        /// <summary>
        /// QI51FPU01.
        /// </summary>
        public const string QI51FPU01 = "QI51FPU01";

        /// <summary>
        /// QI51FJA01.
        /// </summary>
        public const string QI51FJA01 = "QI51FJA01";

        /// <summary>
        /// QI51FJU01.
        /// </summary>
        public const string QI51FJU01 = "QI51FJU01";

        /// <summary>
        /// QI51FCHGA1.
        /// </summary>
        public const string QI51FCHGA1 = "QI51FCHGA1";

        /// <summary>
        /// QI51FCHGU1.
        /// </summary>
        public const string QI51FCHGU1 = "QI51FCHGU1";

        /// <summary>
        /// QI51FEACA1.
        /// </summary>
        public const string QI51FEACA1 = "QI51FEACA1";

        /// <summary>
        /// QI51FEACU1.
        /// </summary>
        public const string QI51FEACU1 = "QI51FEACU1";

        /// <summary>
        /// QI51FETCA1.
        /// </summary>
        public const string QI51FETCA1 = "QI51FETCA1";

        /// <summary>
        /// QI51FETCU1.
        /// </summary>
        public const string QI51FETCU1 = "QI51FETCU1";

        /// <summary>
        /// QI51FTBCA1.
        /// </summary>
        public const string QI51FTBCA1 = "QI51FTBCA1";

        /// <summary>
        /// QI51FTBCU1.
        /// </summary>
        public const string QI51FTBCU1 = "QI51FTBCU1";

        /// <summary>
        /// QI51FFBA1.
        /// </summary>
        public const string QI51FFBA1 = "QI51FFBA1";

        /// <summary>
        /// QI51FFBU1.
        /// </summary>
        public const string QI51FFBU1 = "QI51FFBU1";

        /// <summary>
        /// QI51FTOTA1.
        /// </summary>
        public const string QI51FTOTA1 = "QI51FTOTA1";

        /// <summary>
        /// QI51FTOTU1.
        /// </summary>
        public const string QI51FTOTU1 = "QI51FTOTU1";

        /// <summary>
        /// QI51FRMK.
        /// </summary>
        public const string QI51FRMK = "QI51FRMK";

        /// <summary>
        /// QI51FMOID.
        /// </summary>
        public const string QI51FMOID = "QI51FMOID";

        /// <summary>
        /// QI51FMO.
        /// </summary>
        public const string QI51FMO = "QI51FMO";

        /// <summary>
        /// QITORG.
        /// </summary>
        public const string QITORG = "QITORG";

        /// <summary>
        /// QIENTJ.
        /// </summary>
        public const string QIENTJ = "QIENTJ";

        /// <summary>
        /// QITENT.
        /// </summary>
        public const string QITENT = "QITENT";

        /// <summary>
        /// QIUSER.
        /// </summary>
        public const string QIUSER = "QIUSER";

        /// <summary>
        /// QIUPMJ.
        /// </summary>
        public const string QIUPMJ = "QIUPMJ";

        /// <summary>
        /// QIUPMT.
        /// </summary>
        public const string QIUPMT = "QIUPMT";

        /// <summary>
        /// QIJOBN.
        /// </summary>
        public const string QIJOBN = "QIJOBN";

        /// <summary>
        /// QIPID.
        /// </summary>
        public const string QIPID = "QIPID";

        /// <summary>
        /// QIMKEY.
        /// </summary>
        public const string QIMKEY = "QIMKEY";

        /// <summary>
        /// QI51FBLNET.
        /// </summary>
        public const string QI51FBLNET = "QI51FBLNET";

        /// <summary>
        /// QI51FBLTAX.
        /// </summary>
        public const string QI51FBLTAX = "QI51FBLTAX";

        /// <summary>
        /// QI51FBLTOT.
        /// </summary>
        public const string QI51FBLTOT = "QI51FBLTOT";

        /// <summary>
        /// QI51FUNNET.
        /// </summary>
        public const string QI51FUNNET = "QI51FUNNET";

        /// <summary>
        /// QI51FUNTAX.
        /// </summary>
        public const string QI51FUNTAX = "QI51FUNTAX";

        /// <summary>
        /// QI51FUNTOT.
        /// </summary>
        public const string QI51FUNTOT = "QI51FUNTOT";

        /// <summary>
        /// QI51FRECD.
        /// </summary>
        public const string QI51FRECD = "QI51FRECD";

        /// <summary>
        /// QI51FRETN.
        /// </summary>
        public const string QI51FRETN = "QI51FRETN";

        /// <summary>
        /// QI51FFHA.
        /// </summary>
        public const string QI51FFHA = "QI51FFHA";

        /// <summary>
        /// QI51FFHU.
        /// </summary>
        public const string QI51FFHU = "QI51FFHU";

        /// <summary>
        /// QI51FCTCR.
        /// </summary>
        public const string QI51FCTCR = "QI51FCTCR";

        /// <summary>
        /// QI51FTWU.
        /// </summary>
        public const string QI51FTWU = "QI51FTWU";
    }

    /// <inheritdoc />
    public override string TableName => "F51F125";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("QI51FFID", "QI51FFID", JdeDataType.Numeric, null, true, true),
        new JdeField("QI51FFHID", "QI51FFHID", JdeDataType.Numeric, null, true, true),
        new JdeField("QIAID", "QIAID", JdeDataType.String, 16, true, true),
        new JdeField("QIMCU", "QIMCU", JdeDataType.String, 24),
        new JdeField("QISUB", "QISUB", JdeDataType.String, 16),
        new JdeField("QIOBJ", "QIOBJ", JdeDataType.String, 12),
        new JdeField("QICCT", "QICCT", JdeDataType.String, 2),
        new JdeField("QI51FMOCF", "QI51FMOCF", JdeDataType.String, 2),
        new JdeField("QI51FAA01", "QI51FAA01", JdeDataType.Numeric),
        new JdeField("QI51FAU01", "QI51FAU01", JdeDataType.Numeric),
        new JdeField("QI51FPA01", "QI51FPA01", JdeDataType.Numeric),
        new JdeField("QI51FPU01", "QI51FPU01", JdeDataType.Numeric),
        new JdeField("QI51FJA01", "QI51FJA01", JdeDataType.Numeric),
        new JdeField("QI51FJU01", "QI51FJU01", JdeDataType.Numeric),
        new JdeField("QI51FCHGA1", "QI51FCHGA1", JdeDataType.Numeric),
        new JdeField("QI51FCHGU1", "QI51FCHGU1", JdeDataType.Numeric),
        new JdeField("QI51FEACA1", "QI51FEACA1", JdeDataType.Numeric),
        new JdeField("QI51FEACU1", "QI51FEACU1", JdeDataType.Numeric),
        new JdeField("QI51FETCA1", "QI51FETCA1", JdeDataType.Numeric),
        new JdeField("QI51FETCU1", "QI51FETCU1", JdeDataType.Numeric),
        new JdeField("QI51FTBCA1", "QI51FTBCA1", JdeDataType.Numeric),
        new JdeField("QI51FTBCU1", "QI51FTBCU1", JdeDataType.Numeric),
        new JdeField("QI51FFBA1", "QI51FFBA1", JdeDataType.Numeric),
        new JdeField("QI51FFBU1", "QI51FFBU1", JdeDataType.Numeric),
        new JdeField("QI51FTOTA1", "QI51FTOTA1", JdeDataType.Numeric),
        new JdeField("QI51FTOTU1", "QI51FTOTU1", JdeDataType.Numeric),
        new JdeField("QI51FRMK", "QI51FRMK", JdeDataType.String, 160),
        new JdeField("QI51FMOID", "QI51FMOID", JdeDataType.Numeric),
        new JdeField("QI51FMO", "QI51FMO", JdeDataType.String, 2),
        new JdeField("QITORG", "QITORG", JdeDataType.String, 20),
        new JdeField("QIENTJ", "QIENTJ", JdeDataType.Numeric),
        new JdeField("QITENT", "QITENT", JdeDataType.Numeric),
        new JdeField("QIUSER", "QIUSER", JdeDataType.String, 20),
        new JdeField("QIUPMJ", "QIUPMJ", JdeDataType.Numeric),
        new JdeField("QIUPMT", "QIUPMT", JdeDataType.Numeric),
        new JdeField("QIJOBN", "QIJOBN", JdeDataType.String, 20),
        new JdeField("QIPID", "QIPID", JdeDataType.String, 20),
        new JdeField("QIMKEY", "QIMKEY", JdeDataType.String, 30),
        new JdeField("QI51FBLNET", "QI51FBLNET", JdeDataType.Numeric),
        new JdeField("QI51FBLTAX", "QI51FBLTAX", JdeDataType.Numeric),
        new JdeField("QI51FBLTOT", "QI51FBLTOT", JdeDataType.Numeric),
        new JdeField("QI51FUNNET", "QI51FUNNET", JdeDataType.Numeric),
        new JdeField("QI51FUNTAX", "QI51FUNTAX", JdeDataType.Numeric),
        new JdeField("QI51FUNTOT", "QI51FUNTOT", JdeDataType.Numeric),
        new JdeField("QI51FRECD", "QI51FRECD", JdeDataType.Numeric),
        new JdeField("QI51FRETN", "QI51FRETN", JdeDataType.Numeric),
        new JdeField("QI51FFHA", "QI51FFHA", JdeDataType.Numeric),
        new JdeField("QI51FFHU", "QI51FFHU", JdeDataType.Numeric),
        new JdeField("QI51FCTCR", "QI51FCTCR", JdeDataType.Numeric),
        new JdeField("QI51FTWU", "QI51FTWU", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F51F125_0", "Primary Key on QI51FFID, QI51FFHID, QIAID", new[] { "QI51FFID", "QI51FFHID", "QIAID" }, isUnique: true, isPrimaryKey: true)
    };
}
