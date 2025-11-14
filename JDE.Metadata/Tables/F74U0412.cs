using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F74U0412 - .
/// </summary>
public class F74U0412 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// ACDOCO.
        /// </summary>
        public const string ACDOCO = "ACDOCO";

        /// <summary>
        /// ACDCTO.
        /// </summary>
        public const string ACDCTO = "ACDCTO";

        /// <summary>
        /// ACKCOO.
        /// </summary>
        public const string ACKCOO = "ACKCOO";

        /// <summary>
        /// ACAID.
        /// </summary>
        public const string ACAID = "ACAID";

        /// <summary>
        /// ACCTRY.
        /// </summary>
        public const string ACCTRY = "ACCTRY";

        /// <summary>
        /// ACFY.
        /// </summary>
        public const string ACFY = "ACFY";

        /// <summary>
        /// ACLT.
        /// </summary>
        public const string ACLT = "ACLT";

        /// <summary>
        /// ACMCUS.
        /// </summary>
        public const string ACMCUS = "ACMCUS";

        /// <summary>
        /// ACAN8O.
        /// </summary>
        public const string ACAN8O = "ACAN8O";

        /// <summary>
        /// ACAN01.
        /// </summary>
        public const string ACAN01 = "ACAN01";

        /// <summary>
        /// ACAN02.
        /// </summary>
        public const string ACAN02 = "ACAN02";

        /// <summary>
        /// ACAN03.
        /// </summary>
        public const string ACAN03 = "ACAN03";

        /// <summary>
        /// ACAN04.
        /// </summary>
        public const string ACAN04 = "ACAN04";

        /// <summary>
        /// ACAN05.
        /// </summary>
        public const string ACAN05 = "ACAN05";

        /// <summary>
        /// ACAN06.
        /// </summary>
        public const string ACAN06 = "ACAN06";

        /// <summary>
        /// ACAN07.
        /// </summary>
        public const string ACAN07 = "ACAN07";

        /// <summary>
        /// ACAN08.
        /// </summary>
        public const string ACAN08 = "ACAN08";

        /// <summary>
        /// ACAN09.
        /// </summary>
        public const string ACAN09 = "ACAN09";

        /// <summary>
        /// ACAN10.
        /// </summary>
        public const string ACAN10 = "ACAN10";

        /// <summary>
        /// ACAN11.
        /// </summary>
        public const string ACAN11 = "ACAN11";

        /// <summary>
        /// ACAN12.
        /// </summary>
        public const string ACAN12 = "ACAN12";

        /// <summary>
        /// ACAN13.
        /// </summary>
        public const string ACAN13 = "ACAN13";

        /// <summary>
        /// ACAN14.
        /// </summary>
        public const string ACAN14 = "ACAN14";

        /// <summary>
        /// ACMCU.
        /// </summary>
        public const string ACMCU = "ACMCU";

        /// <summary>
        /// ACOBJ.
        /// </summary>
        public const string ACOBJ = "ACOBJ";

        /// <summary>
        /// ACSUB.
        /// </summary>
        public const string ACSUB = "ACSUB";

        /// <summary>
        /// ACUSER.
        /// </summary>
        public const string ACUSER = "ACUSER";

        /// <summary>
        /// ACPID.
        /// </summary>
        public const string ACPID = "ACPID";

        /// <summary>
        /// ACUPMJ.
        /// </summary>
        public const string ACUPMJ = "ACUPMJ";

        /// <summary>
        /// ACUPMT.
        /// </summary>
        public const string ACUPMT = "ACUPMT";

        /// <summary>
        /// ACJOBN.
        /// </summary>
        public const string ACJOBN = "ACJOBN";

        /// <summary>
        /// ACEV01.
        /// </summary>
        public const string ACEV01 = "ACEV01";
    }

    /// <inheritdoc />
    public override string TableName => "F74U0412";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("ACDOCO", "ACDOCO", JdeDataType.Numeric, null, true, true),
        new JdeField("ACDCTO", "ACDCTO", JdeDataType.String, 4, true, true),
        new JdeField("ACKCOO", "ACKCOO", JdeDataType.String, 10, true, true),
        new JdeField("ACAID", "ACAID", JdeDataType.String, 16, true, true),
        new JdeField("ACCTRY", "ACCTRY", JdeDataType.Numeric, null, true, true),
        new JdeField("ACFY", "ACFY", JdeDataType.Numeric, null, true, true),
        new JdeField("ACLT", "ACLT", JdeDataType.String, 4, true, true),
        new JdeField("ACMCUS", "ACMCUS", JdeDataType.String, 24),
        new JdeField("ACAN8O", "ACAN8O", JdeDataType.Numeric),
        new JdeField("ACAN01", "ACAN01", JdeDataType.Numeric),
        new JdeField("ACAN02", "ACAN02", JdeDataType.Numeric),
        new JdeField("ACAN03", "ACAN03", JdeDataType.Numeric),
        new JdeField("ACAN04", "ACAN04", JdeDataType.Numeric),
        new JdeField("ACAN05", "ACAN05", JdeDataType.Numeric),
        new JdeField("ACAN06", "ACAN06", JdeDataType.Numeric),
        new JdeField("ACAN07", "ACAN07", JdeDataType.Numeric),
        new JdeField("ACAN08", "ACAN08", JdeDataType.Numeric),
        new JdeField("ACAN09", "ACAN09", JdeDataType.Numeric),
        new JdeField("ACAN10", "ACAN10", JdeDataType.Numeric),
        new JdeField("ACAN11", "ACAN11", JdeDataType.Numeric),
        new JdeField("ACAN12", "ACAN12", JdeDataType.Numeric),
        new JdeField("ACAN13", "ACAN13", JdeDataType.Numeric),
        new JdeField("ACAN14", "ACAN14", JdeDataType.Numeric),
        new JdeField("ACMCU", "ACMCU", JdeDataType.String, 24),
        new JdeField("ACOBJ", "ACOBJ", JdeDataType.String, 12),
        new JdeField("ACSUB", "ACSUB", JdeDataType.String, 16),
        new JdeField("ACUSER", "ACUSER", JdeDataType.String, 20),
        new JdeField("ACPID", "ACPID", JdeDataType.String, 20),
        new JdeField("ACUPMJ", "ACUPMJ", JdeDataType.Numeric),
        new JdeField("ACUPMT", "ACUPMT", JdeDataType.Numeric),
        new JdeField("ACJOBN", "ACJOBN", JdeDataType.String, 20),
        new JdeField("ACEV01", "ACEV01", JdeDataType.String, 2)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F74U0412_0", "Primary Key on ACDOCO, ACDCTO, ACKCOO, ACAID, ACCTRY, ACFY, ACLT", new[] { "ACDOCO", "ACDCTO", "ACKCOO", "ACAID", "ACCTRY", "ACFY", "ACLT" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F74U0412_2", "Index on ACEV01", new[] { "ACEV01" })
    };
}
