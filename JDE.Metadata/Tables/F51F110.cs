using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F51F110 - .
/// </summary>
public class F51F110 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// QG51FFID.
        /// </summary>
        public const string QG51FFID = "QG51FFID";

        /// <summary>
        /// QGAID.
        /// </summary>
        public const string QGAID = "QGAID";

        /// <summary>
        /// QGMCU.
        /// </summary>
        public const string QGMCU = "QGMCU";

        /// <summary>
        /// QGSUB.
        /// </summary>
        public const string QGSUB = "QGSUB";

        /// <summary>
        /// QGOBJ.
        /// </summary>
        public const string QGOBJ = "QGOBJ";

        /// <summary>
        /// QGCCT.
        /// </summary>
        public const string QGCCT = "QGCCT";

        /// <summary>
        /// QG51FMOCF.
        /// </summary>
        public const string QG51FMOCF = "QG51FMOCF";

        /// <summary>
        /// QG51FAA01.
        /// </summary>
        public const string QG51FAA01 = "QG51FAA01";

        /// <summary>
        /// QG51FAU01.
        /// </summary>
        public const string QG51FAU01 = "QG51FAU01";

        /// <summary>
        /// QG51FPA01.
        /// </summary>
        public const string QG51FPA01 = "QG51FPA01";

        /// <summary>
        /// QG51FPU01.
        /// </summary>
        public const string QG51FPU01 = "QG51FPU01";

        /// <summary>
        /// QG51FJA01.
        /// </summary>
        public const string QG51FJA01 = "QG51FJA01";

        /// <summary>
        /// QG51FJU01.
        /// </summary>
        public const string QG51FJU01 = "QG51FJU01";

        /// <summary>
        /// QG51FCHGA1.
        /// </summary>
        public const string QG51FCHGA1 = "QG51FCHGA1";

        /// <summary>
        /// QG51FCHGU1.
        /// </summary>
        public const string QG51FCHGU1 = "QG51FCHGU1";

        /// <summary>
        /// QG51FEACA1.
        /// </summary>
        public const string QG51FEACA1 = "QG51FEACA1";

        /// <summary>
        /// QG51FEACU1.
        /// </summary>
        public const string QG51FEACU1 = "QG51FEACU1";

        /// <summary>
        /// QG51FETCA1.
        /// </summary>
        public const string QG51FETCA1 = "QG51FETCA1";

        /// <summary>
        /// QG51FETCU1.
        /// </summary>
        public const string QG51FETCU1 = "QG51FETCU1";

        /// <summary>
        /// QG51FTBCA1.
        /// </summary>
        public const string QG51FTBCA1 = "QG51FTBCA1";

        /// <summary>
        /// QG51FTBCU1.
        /// </summary>
        public const string QG51FTBCU1 = "QG51FTBCU1";

        /// <summary>
        /// QG51FFBA1.
        /// </summary>
        public const string QG51FFBA1 = "QG51FFBA1";

        /// <summary>
        /// QG51FFBU1.
        /// </summary>
        public const string QG51FFBU1 = "QG51FFBU1";

        /// <summary>
        /// QG51FTOTA1.
        /// </summary>
        public const string QG51FTOTA1 = "QG51FTOTA1";

        /// <summary>
        /// QG51FTOTU1.
        /// </summary>
        public const string QG51FTOTU1 = "QG51FTOTU1";

        /// <summary>
        /// QG51FRMK.
        /// </summary>
        public const string QG51FRMK = "QG51FRMK";

        /// <summary>
        /// QG51FMOID.
        /// </summary>
        public const string QG51FMOID = "QG51FMOID";

        /// <summary>
        /// QG51FMO.
        /// </summary>
        public const string QG51FMO = "QG51FMO";

        /// <summary>
        /// QGTORG.
        /// </summary>
        public const string QGTORG = "QGTORG";

        /// <summary>
        /// QGENTJ.
        /// </summary>
        public const string QGENTJ = "QGENTJ";

        /// <summary>
        /// QGTENT.
        /// </summary>
        public const string QGTENT = "QGTENT";

        /// <summary>
        /// QGUSER.
        /// </summary>
        public const string QGUSER = "QGUSER";

        /// <summary>
        /// QGUPMJ.
        /// </summary>
        public const string QGUPMJ = "QGUPMJ";

        /// <summary>
        /// QGUPMT.
        /// </summary>
        public const string QGUPMT = "QGUPMT";

        /// <summary>
        /// QGJOBN.
        /// </summary>
        public const string QGJOBN = "QGJOBN";

        /// <summary>
        /// QGPID.
        /// </summary>
        public const string QGPID = "QGPID";

        /// <summary>
        /// QGMKEY.
        /// </summary>
        public const string QGMKEY = "QGMKEY";

        /// <summary>
        /// QG51FBLNET.
        /// </summary>
        public const string QG51FBLNET = "QG51FBLNET";

        /// <summary>
        /// QG51FBLTAX.
        /// </summary>
        public const string QG51FBLTAX = "QG51FBLTAX";

        /// <summary>
        /// QG51FBLTOT.
        /// </summary>
        public const string QG51FBLTOT = "QG51FBLTOT";

        /// <summary>
        /// QG51FUNNET.
        /// </summary>
        public const string QG51FUNNET = "QG51FUNNET";

        /// <summary>
        /// QG51FUNTAX.
        /// </summary>
        public const string QG51FUNTAX = "QG51FUNTAX";

        /// <summary>
        /// QG51FUNTOT.
        /// </summary>
        public const string QG51FUNTOT = "QG51FUNTOT";

        /// <summary>
        /// QG51FRECD.
        /// </summary>
        public const string QG51FRECD = "QG51FRECD";

        /// <summary>
        /// QG51FRETN.
        /// </summary>
        public const string QG51FRETN = "QG51FRETN";

        /// <summary>
        /// QG51FCTCR.
        /// </summary>
        public const string QG51FCTCR = "QG51FCTCR";

        /// <summary>
        /// QG51FTWU.
        /// </summary>
        public const string QG51FTWU = "QG51FTWU";

        /// <summary>
        /// QG51FEACA3.
        /// </summary>
        public const string QG51FEACA3 = "QG51FEACA3";

        /// <summary>
        /// QG51FETCA3.
        /// </summary>
        public const string QG51FETCA3 = "QG51FETCA3";

        /// <summary>
        /// QG51FTOTA2.
        /// </summary>
        public const string QG51FTOTA2 = "QG51FTOTA2";

        /// <summary>
        /// QG51FEACU3.
        /// </summary>
        public const string QG51FEACU3 = "QG51FEACU3";

        /// <summary>
        /// QG51FETCU3.
        /// </summary>
        public const string QG51FETCU3 = "QG51FETCU3";

        /// <summary>
        /// QG51FTOTU2.
        /// </summary>
        public const string QG51FTOTU2 = "QG51FTOTU2";
    }

    /// <inheritdoc />
    public override string TableName => "F51F110";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("QG51FFID", "QG51FFID", JdeDataType.Numeric, null, true, true),
        new JdeField("QGAID", "QGAID", JdeDataType.String, 16, true, true),
        new JdeField("QGMCU", "QGMCU", JdeDataType.String, 24),
        new JdeField("QGSUB", "QGSUB", JdeDataType.String, 16),
        new JdeField("QGOBJ", "QGOBJ", JdeDataType.String, 12),
        new JdeField("QGCCT", "QGCCT", JdeDataType.String, 2),
        new JdeField("QG51FMOCF", "QG51FMOCF", JdeDataType.String, 2),
        new JdeField("QG51FAA01", "QG51FAA01", JdeDataType.Numeric),
        new JdeField("QG51FAU01", "QG51FAU01", JdeDataType.Numeric),
        new JdeField("QG51FPA01", "QG51FPA01", JdeDataType.Numeric),
        new JdeField("QG51FPU01", "QG51FPU01", JdeDataType.Numeric),
        new JdeField("QG51FJA01", "QG51FJA01", JdeDataType.Numeric),
        new JdeField("QG51FJU01", "QG51FJU01", JdeDataType.Numeric),
        new JdeField("QG51FCHGA1", "QG51FCHGA1", JdeDataType.Numeric),
        new JdeField("QG51FCHGU1", "QG51FCHGU1", JdeDataType.Numeric),
        new JdeField("QG51FEACA1", "QG51FEACA1", JdeDataType.Numeric),
        new JdeField("QG51FEACU1", "QG51FEACU1", JdeDataType.Numeric),
        new JdeField("QG51FETCA1", "QG51FETCA1", JdeDataType.Numeric),
        new JdeField("QG51FETCU1", "QG51FETCU1", JdeDataType.Numeric),
        new JdeField("QG51FTBCA1", "QG51FTBCA1", JdeDataType.Numeric),
        new JdeField("QG51FTBCU1", "QG51FTBCU1", JdeDataType.Numeric),
        new JdeField("QG51FFBA1", "QG51FFBA1", JdeDataType.Numeric),
        new JdeField("QG51FFBU1", "QG51FFBU1", JdeDataType.Numeric),
        new JdeField("QG51FTOTA1", "QG51FTOTA1", JdeDataType.Numeric),
        new JdeField("QG51FTOTU1", "QG51FTOTU1", JdeDataType.Numeric),
        new JdeField("QG51FRMK", "QG51FRMK", JdeDataType.String, 160),
        new JdeField("QG51FMOID", "QG51FMOID", JdeDataType.Numeric),
        new JdeField("QG51FMO", "QG51FMO", JdeDataType.String, 2),
        new JdeField("QGTORG", "QGTORG", JdeDataType.String, 20),
        new JdeField("QGENTJ", "QGENTJ", JdeDataType.Numeric),
        new JdeField("QGTENT", "QGTENT", JdeDataType.Numeric),
        new JdeField("QGUSER", "QGUSER", JdeDataType.String, 20),
        new JdeField("QGUPMJ", "QGUPMJ", JdeDataType.Numeric),
        new JdeField("QGUPMT", "QGUPMT", JdeDataType.Numeric),
        new JdeField("QGJOBN", "QGJOBN", JdeDataType.String, 20),
        new JdeField("QGPID", "QGPID", JdeDataType.String, 20),
        new JdeField("QGMKEY", "QGMKEY", JdeDataType.String, 30),
        new JdeField("QG51FBLNET", "QG51FBLNET", JdeDataType.Numeric),
        new JdeField("QG51FBLTAX", "QG51FBLTAX", JdeDataType.Numeric),
        new JdeField("QG51FBLTOT", "QG51FBLTOT", JdeDataType.Numeric),
        new JdeField("QG51FUNNET", "QG51FUNNET", JdeDataType.Numeric),
        new JdeField("QG51FUNTAX", "QG51FUNTAX", JdeDataType.Numeric),
        new JdeField("QG51FUNTOT", "QG51FUNTOT", JdeDataType.Numeric),
        new JdeField("QG51FRECD", "QG51FRECD", JdeDataType.Numeric),
        new JdeField("QG51FRETN", "QG51FRETN", JdeDataType.Numeric),
        new JdeField("QG51FCTCR", "QG51FCTCR", JdeDataType.Numeric),
        new JdeField("QG51FTWU", "QG51FTWU", JdeDataType.Numeric),
        new JdeField("QG51FEACA3", "QG51FEACA3", JdeDataType.String, 2),
        new JdeField("QG51FETCA3", "QG51FETCA3", JdeDataType.String, 2),
        new JdeField("QG51FTOTA2", "QG51FTOTA2", JdeDataType.String, 2),
        new JdeField("QG51FEACU3", "QG51FEACU3", JdeDataType.String, 2),
        new JdeField("QG51FETCU3", "QG51FETCU3", JdeDataType.String, 2),
        new JdeField("QG51FTOTU2", "QG51FTOTU2", JdeDataType.String, 2)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F51F110_0", "Primary Key on QG51FFID, QGAID", new[] { "QG51FFID", "QGAID" }, isUnique: true, isPrimaryKey: true)
    };
}
