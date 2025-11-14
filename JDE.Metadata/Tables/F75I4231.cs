using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F75I4231 - .
/// </summary>
public class F75I4231 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// PTUSER.
        /// </summary>
        public const string PTUSER = "PTUSER";

        /// <summary>
        /// PTJOBN.
        /// </summary>
        public const string PTJOBN = "PTJOBN";

        /// <summary>
        /// PTPID.
        /// </summary>
        public const string PTPID = "PTPID";

        /// <summary>
        /// PTUPMT.
        /// </summary>
        public const string PTUPMT = "PTUPMT";

        /// <summary>
        /// PTUPMJ.
        /// </summary>
        public const string PTUPMJ = "PTUPMJ";

        /// <summary>
        /// PTLINENBR.
        /// </summary>
        public const string PTLINENBR = "PTLINENBR";

        /// <summary>
        /// PTMCU.
        /// </summary>
        public const string PTMCU = "PTMCU";

        /// <summary>
        /// PTLVLA.
        /// </summary>
        public const string PTLVLA = "PTLVLA";

        /// <summary>
        /// PTPCST.
        /// </summary>
        public const string PTPCST = "PTPCST";

        /// <summary>
        /// PTPRP5.
        /// </summary>
        public const string PTPRP5 = "PTPRP5";

        /// <summary>
        /// PTDOC.
        /// </summary>
        public const string PTDOC = "PTDOC";

        /// <summary>
        /// PTDCT.
        /// </summary>
        public const string PTDCT = "PTDCT";

        /// <summary>
        /// PTDGL.
        /// </summary>
        public const string PTDGL = "PTDGL";

        /// <summary>
        /// PTDOCO.
        /// </summary>
        public const string PTDOCO = "PTDOCO";

        /// <summary>
        /// PTDCTO.
        /// </summary>
        public const string PTDCTO = "PTDCTO";

        /// <summary>
        /// PTLNID.
        /// </summary>
        public const string PTLNID = "PTLNID";

        /// <summary>
        /// PTAYPD.
        /// </summary>
        public const string PTAYPD = "PTAYPD";

        /// <summary>
        /// PTAREC.
        /// </summary>
        public const string PTAREC = "PTAREC";

        /// <summary>
        /// PTAFA1.
        /// </summary>
        public const string PTAFA1 = "PTAFA1";

        /// <summary>
        /// PTAFA2.
        /// </summary>
        public const string PTAFA2 = "PTAFA2";

        /// <summary>
        /// PTAFA3.
        /// </summary>
        public const string PTAFA3 = "PTAFA3";

        /// <summary>
        /// PTAFA4.
        /// </summary>
        public const string PTAFA4 = "PTAFA4";

        /// <summary>
        /// PTAFA5.
        /// </summary>
        public const string PTAFA5 = "PTAFA5";

        /// <summary>
        /// PTAFA6.
        /// </summary>
        public const string PTAFA6 = "PTAFA6";

        /// <summary>
        /// PTAFA7.
        /// </summary>
        public const string PTAFA7 = "PTAFA7";

        /// <summary>
        /// PTAFA8.
        /// </summary>
        public const string PTAFA8 = "PTAFA8";

        /// <summary>
        /// PTAFA9.
        /// </summary>
        public const string PTAFA9 = "PTAFA9";

        /// <summary>
        /// PTEF01.
        /// </summary>
        public const string PTEF01 = "PTEF01";

        /// <summary>
        /// PTKCOO.
        /// </summary>
        public const string PTKCOO = "PTKCOO";
    }

    /// <inheritdoc />
    public override string TableName => "F75I4231";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("PTUSER", "PTUSER", JdeDataType.String, 20, true, true),
        new JdeField("PTJOBN", "PTJOBN", JdeDataType.String, 20, true, true),
        new JdeField("PTPID", "PTPID", JdeDataType.String, 20, true, true),
        new JdeField("PTUPMT", "PTUPMT", JdeDataType.Numeric, null, true, true),
        new JdeField("PTUPMJ", "PTUPMJ", JdeDataType.Numeric, null, true, true),
        new JdeField("PTLINENBR", "PTLINENBR", JdeDataType.Numeric, null, true, true),
        new JdeField("PTMCU", "PTMCU", JdeDataType.String, 24),
        new JdeField("PTLVLA", "PTLVLA", JdeDataType.String, 6),
        new JdeField("PTPCST", "PTPCST", JdeDataType.Numeric),
        new JdeField("PTPRP5", "PTPRP5", JdeDataType.String, 6),
        new JdeField("PTDOC", "PTDOC", JdeDataType.Numeric),
        new JdeField("PTDCT", "PTDCT", JdeDataType.String, 4),
        new JdeField("PTDGL", "PTDGL", JdeDataType.Numeric),
        new JdeField("PTDOCO", "PTDOCO", JdeDataType.Numeric),
        new JdeField("PTDCTO", "PTDCTO", JdeDataType.String, 4),
        new JdeField("PTLNID", "PTLNID", JdeDataType.Numeric),
        new JdeField("PTAYPD", "PTAYPD", JdeDataType.Numeric),
        new JdeField("PTAREC", "PTAREC", JdeDataType.Numeric),
        new JdeField("PTAFA1", "PTAFA1", JdeDataType.Numeric),
        new JdeField("PTAFA2", "PTAFA2", JdeDataType.Numeric),
        new JdeField("PTAFA3", "PTAFA3", JdeDataType.Numeric),
        new JdeField("PTAFA4", "PTAFA4", JdeDataType.Numeric),
        new JdeField("PTAFA5", "PTAFA5", JdeDataType.Numeric),
        new JdeField("PTAFA6", "PTAFA6", JdeDataType.Numeric),
        new JdeField("PTAFA7", "PTAFA7", JdeDataType.Numeric),
        new JdeField("PTAFA8", "PTAFA8", JdeDataType.Numeric),
        new JdeField("PTAFA9", "PTAFA9", JdeDataType.Numeric),
        new JdeField("PTEF01", "PTEF01", JdeDataType.Numeric),
        new JdeField("PTKCOO", "PTKCOO", JdeDataType.String, 10)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F75I4231_0", "Primary Key on PTUSER, PTJOBN, PTLINENBR, PTPID, PTUPMT, PTUPMJ", new[] { "PTUSER", "PTJOBN", "PTLINENBR", "PTPID", "PTUPMT", "PTUPMJ" }, isUnique: true, isPrimaryKey: true)
    };
}
