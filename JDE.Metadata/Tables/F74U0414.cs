using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F74U0414 - .
/// </summary>
public class F74U0414 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// CCDOCO.
        /// </summary>
        public const string CCDOCO = "CCDOCO";

        /// <summary>
        /// CCDCTO.
        /// </summary>
        public const string CCDCTO = "CCDCTO";

        /// <summary>
        /// CCKCOO.
        /// </summary>
        public const string CCKCOO = "CCKCOO";

        /// <summary>
        /// CCAID.
        /// </summary>
        public const string CCAID = "CCAID";

        /// <summary>
        /// CCCTRY.
        /// </summary>
        public const string CCCTRY = "CCCTRY";

        /// <summary>
        /// CCFY.
        /// </summary>
        public const string CCFY = "CCFY";

        /// <summary>
        /// CCLT.
        /// </summary>
        public const string CCLT = "CCLT";

        /// <summary>
        /// CCMCUS.
        /// </summary>
        public const string CCMCUS = "CCMCUS";

        /// <summary>
        /// CCAN8O.
        /// </summary>
        public const string CCAN8O = "CCAN8O";

        /// <summary>
        /// CCAN01.
        /// </summary>
        public const string CCAN01 = "CCAN01";

        /// <summary>
        /// CCAN02.
        /// </summary>
        public const string CCAN02 = "CCAN02";

        /// <summary>
        /// CCAN03.
        /// </summary>
        public const string CCAN03 = "CCAN03";

        /// <summary>
        /// CCAN04.
        /// </summary>
        public const string CCAN04 = "CCAN04";

        /// <summary>
        /// CCAN05.
        /// </summary>
        public const string CCAN05 = "CCAN05";

        /// <summary>
        /// CCAN06.
        /// </summary>
        public const string CCAN06 = "CCAN06";

        /// <summary>
        /// CCAN07.
        /// </summary>
        public const string CCAN07 = "CCAN07";

        /// <summary>
        /// CCAN08.
        /// </summary>
        public const string CCAN08 = "CCAN08";

        /// <summary>
        /// CCAN09.
        /// </summary>
        public const string CCAN09 = "CCAN09";

        /// <summary>
        /// CCAN10.
        /// </summary>
        public const string CCAN10 = "CCAN10";

        /// <summary>
        /// CCAN11.
        /// </summary>
        public const string CCAN11 = "CCAN11";

        /// <summary>
        /// CCAN12.
        /// </summary>
        public const string CCAN12 = "CCAN12";

        /// <summary>
        /// CCAN13.
        /// </summary>
        public const string CCAN13 = "CCAN13";

        /// <summary>
        /// CCAN14.
        /// </summary>
        public const string CCAN14 = "CCAN14";

        /// <summary>
        /// CCMCU.
        /// </summary>
        public const string CCMCU = "CCMCU";

        /// <summary>
        /// CCOBJ.
        /// </summary>
        public const string CCOBJ = "CCOBJ";

        /// <summary>
        /// CCSUB.
        /// </summary>
        public const string CCSUB = "CCSUB";

        /// <summary>
        /// CCUSER.
        /// </summary>
        public const string CCUSER = "CCUSER";

        /// <summary>
        /// CCPID.
        /// </summary>
        public const string CCPID = "CCPID";

        /// <summary>
        /// CCUPMJ.
        /// </summary>
        public const string CCUPMJ = "CCUPMJ";

        /// <summary>
        /// CCUPMT.
        /// </summary>
        public const string CCUPMT = "CCUPMT";

        /// <summary>
        /// CCJOBN.
        /// </summary>
        public const string CCJOBN = "CCJOBN";

        /// <summary>
        /// CCEV01.
        /// </summary>
        public const string CCEV01 = "CCEV01";
    }

    /// <inheritdoc />
    public override string TableName => "F74U0414";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("CCDOCO", "CCDOCO", JdeDataType.Numeric, null, true, true),
        new JdeField("CCDCTO", "CCDCTO", JdeDataType.String, 4, true, true),
        new JdeField("CCKCOO", "CCKCOO", JdeDataType.String, 10, true, true),
        new JdeField("CCAID", "CCAID", JdeDataType.String, 16, true, true),
        new JdeField("CCCTRY", "CCCTRY", JdeDataType.Numeric, null, true, true),
        new JdeField("CCFY", "CCFY", JdeDataType.Numeric, null, true, true),
        new JdeField("CCLT", "CCLT", JdeDataType.String, 4, true, true),
        new JdeField("CCMCUS", "CCMCUS", JdeDataType.String, 24),
        new JdeField("CCAN8O", "CCAN8O", JdeDataType.Numeric),
        new JdeField("CCAN01", "CCAN01", JdeDataType.Numeric),
        new JdeField("CCAN02", "CCAN02", JdeDataType.Numeric),
        new JdeField("CCAN03", "CCAN03", JdeDataType.Numeric),
        new JdeField("CCAN04", "CCAN04", JdeDataType.Numeric),
        new JdeField("CCAN05", "CCAN05", JdeDataType.Numeric),
        new JdeField("CCAN06", "CCAN06", JdeDataType.Numeric),
        new JdeField("CCAN07", "CCAN07", JdeDataType.Numeric),
        new JdeField("CCAN08", "CCAN08", JdeDataType.Numeric),
        new JdeField("CCAN09", "CCAN09", JdeDataType.Numeric),
        new JdeField("CCAN10", "CCAN10", JdeDataType.Numeric),
        new JdeField("CCAN11", "CCAN11", JdeDataType.Numeric),
        new JdeField("CCAN12", "CCAN12", JdeDataType.Numeric),
        new JdeField("CCAN13", "CCAN13", JdeDataType.Numeric),
        new JdeField("CCAN14", "CCAN14", JdeDataType.Numeric),
        new JdeField("CCMCU", "CCMCU", JdeDataType.String, 24),
        new JdeField("CCOBJ", "CCOBJ", JdeDataType.String, 12),
        new JdeField("CCSUB", "CCSUB", JdeDataType.String, 16),
        new JdeField("CCUSER", "CCUSER", JdeDataType.String, 20),
        new JdeField("CCPID", "CCPID", JdeDataType.String, 20),
        new JdeField("CCUPMJ", "CCUPMJ", JdeDataType.Numeric),
        new JdeField("CCUPMT", "CCUPMT", JdeDataType.Numeric),
        new JdeField("CCJOBN", "CCJOBN", JdeDataType.String, 20),
        new JdeField("CCEV01", "CCEV01", JdeDataType.String, 2)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F74U0414_0", "Primary Key on CCDOCO, CCDCTO, CCKCOO, CCAID, CCCTRY, CCFY, CCLT", new[] { "CCDOCO", "CCDCTO", "CCKCOO", "CCAID", "CCCTRY", "CCFY", "CCLT" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F74U0414_2", "Index on CCEV01", new[] { "CCEV01" })
    };
}
