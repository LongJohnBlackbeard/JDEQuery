using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F74U0416 - .
/// </summary>
public class F74U0416 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// PCDOCO.
        /// </summary>
        public const string PCDOCO = "PCDOCO";

        /// <summary>
        /// PCDCTO.
        /// </summary>
        public const string PCDCTO = "PCDCTO";

        /// <summary>
        /// PCKCOO.
        /// </summary>
        public const string PCKCOO = "PCKCOO";

        /// <summary>
        /// PCAID.
        /// </summary>
        public const string PCAID = "PCAID";

        /// <summary>
        /// PCCTRY.
        /// </summary>
        public const string PCCTRY = "PCCTRY";

        /// <summary>
        /// PCFY.
        /// </summary>
        public const string PCFY = "PCFY";

        /// <summary>
        /// PCLT.
        /// </summary>
        public const string PCLT = "PCLT";

        /// <summary>
        /// PCMCUS.
        /// </summary>
        public const string PCMCUS = "PCMCUS";

        /// <summary>
        /// PCAN8O.
        /// </summary>
        public const string PCAN8O = "PCAN8O";

        /// <summary>
        /// PCAN01.
        /// </summary>
        public const string PCAN01 = "PCAN01";

        /// <summary>
        /// PCAN02.
        /// </summary>
        public const string PCAN02 = "PCAN02";

        /// <summary>
        /// PCAN03.
        /// </summary>
        public const string PCAN03 = "PCAN03";

        /// <summary>
        /// PCAN04.
        /// </summary>
        public const string PCAN04 = "PCAN04";

        /// <summary>
        /// PCAN05.
        /// </summary>
        public const string PCAN05 = "PCAN05";

        /// <summary>
        /// PCAN06.
        /// </summary>
        public const string PCAN06 = "PCAN06";

        /// <summary>
        /// PCAN07.
        /// </summary>
        public const string PCAN07 = "PCAN07";

        /// <summary>
        /// PCAN08.
        /// </summary>
        public const string PCAN08 = "PCAN08";

        /// <summary>
        /// PCAN09.
        /// </summary>
        public const string PCAN09 = "PCAN09";

        /// <summary>
        /// PCAN10.
        /// </summary>
        public const string PCAN10 = "PCAN10";

        /// <summary>
        /// PCAN11.
        /// </summary>
        public const string PCAN11 = "PCAN11";

        /// <summary>
        /// PCAN12.
        /// </summary>
        public const string PCAN12 = "PCAN12";

        /// <summary>
        /// PCAN13.
        /// </summary>
        public const string PCAN13 = "PCAN13";

        /// <summary>
        /// PCAN14.
        /// </summary>
        public const string PCAN14 = "PCAN14";

        /// <summary>
        /// PCMCU.
        /// </summary>
        public const string PCMCU = "PCMCU";

        /// <summary>
        /// PCOBJ.
        /// </summary>
        public const string PCOBJ = "PCOBJ";

        /// <summary>
        /// PCSUB.
        /// </summary>
        public const string PCSUB = "PCSUB";

        /// <summary>
        /// PCUSER.
        /// </summary>
        public const string PCUSER = "PCUSER";

        /// <summary>
        /// PCPID.
        /// </summary>
        public const string PCPID = "PCPID";

        /// <summary>
        /// PCUPMJ.
        /// </summary>
        public const string PCUPMJ = "PCUPMJ";

        /// <summary>
        /// PCUPMT.
        /// </summary>
        public const string PCUPMT = "PCUPMT";

        /// <summary>
        /// PCJOBN.
        /// </summary>
        public const string PCJOBN = "PCJOBN";

        /// <summary>
        /// PCEV01.
        /// </summary>
        public const string PCEV01 = "PCEV01";
    }

    /// <inheritdoc />
    public override string TableName => "F74U0416";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("PCDOCO", "PCDOCO", JdeDataType.Numeric, null, true, true),
        new JdeField("PCDCTO", "PCDCTO", JdeDataType.String, 4, true, true),
        new JdeField("PCKCOO", "PCKCOO", JdeDataType.String, 10, true, true),
        new JdeField("PCAID", "PCAID", JdeDataType.String, 16, true, true),
        new JdeField("PCCTRY", "PCCTRY", JdeDataType.Numeric, null, true, true),
        new JdeField("PCFY", "PCFY", JdeDataType.Numeric, null, true, true),
        new JdeField("PCLT", "PCLT", JdeDataType.String, 4, true, true),
        new JdeField("PCMCUS", "PCMCUS", JdeDataType.String, 24),
        new JdeField("PCAN8O", "PCAN8O", JdeDataType.Numeric),
        new JdeField("PCAN01", "PCAN01", JdeDataType.Numeric),
        new JdeField("PCAN02", "PCAN02", JdeDataType.Numeric),
        new JdeField("PCAN03", "PCAN03", JdeDataType.Numeric),
        new JdeField("PCAN04", "PCAN04", JdeDataType.Numeric),
        new JdeField("PCAN05", "PCAN05", JdeDataType.Numeric),
        new JdeField("PCAN06", "PCAN06", JdeDataType.Numeric),
        new JdeField("PCAN07", "PCAN07", JdeDataType.Numeric),
        new JdeField("PCAN08", "PCAN08", JdeDataType.Numeric),
        new JdeField("PCAN09", "PCAN09", JdeDataType.Numeric),
        new JdeField("PCAN10", "PCAN10", JdeDataType.Numeric),
        new JdeField("PCAN11", "PCAN11", JdeDataType.Numeric),
        new JdeField("PCAN12", "PCAN12", JdeDataType.Numeric),
        new JdeField("PCAN13", "PCAN13", JdeDataType.Numeric),
        new JdeField("PCAN14", "PCAN14", JdeDataType.Numeric),
        new JdeField("PCMCU", "PCMCU", JdeDataType.String, 24),
        new JdeField("PCOBJ", "PCOBJ", JdeDataType.String, 12),
        new JdeField("PCSUB", "PCSUB", JdeDataType.String, 16),
        new JdeField("PCUSER", "PCUSER", JdeDataType.String, 20),
        new JdeField("PCPID", "PCPID", JdeDataType.String, 20),
        new JdeField("PCUPMJ", "PCUPMJ", JdeDataType.Numeric),
        new JdeField("PCUPMT", "PCUPMT", JdeDataType.Numeric),
        new JdeField("PCJOBN", "PCJOBN", JdeDataType.String, 20),
        new JdeField("PCEV01", "PCEV01", JdeDataType.String, 2)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F74U0416_0", "Primary Key on PCDOCO, PCDCTO, PCKCOO, PCAID, PCCTRY, PCFY, PCLT", new[] { "PCDOCO", "PCDCTO", "PCKCOO", "PCAID", "PCCTRY", "PCFY", "PCLT" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F74U0416_2", "Index on PCEV01", new[] { "PCEV01" })
    };
}
