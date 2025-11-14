using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F704102 - .
/// </summary>
public class F704102 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// IBITM.
        /// </summary>
        public const string IBITM = "IBITM";

        /// <summary>
        /// IBLCTR.
        /// </summary>
        public const string IBLCTR = "IBLCTR";

        /// <summary>
        /// IBMCU.
        /// </summary>
        public const string IBMCU = "IBMCU";

        /// <summary>
        /// IBG70CC01.
        /// </summary>
        public const string IBG70CC01 = "IBG70CC01";

        /// <summary>
        /// IBG70CC02.
        /// </summary>
        public const string IBG70CC02 = "IBG70CC02";

        /// <summary>
        /// IBG70CC03.
        /// </summary>
        public const string IBG70CC03 = "IBG70CC03";

        /// <summary>
        /// IBG70CC04.
        /// </summary>
        public const string IBG70CC04 = "IBG70CC04";

        /// <summary>
        /// IBG70CC05.
        /// </summary>
        public const string IBG70CC05 = "IBG70CC05";

        /// <summary>
        /// IBG70CC06.
        /// </summary>
        public const string IBG70CC06 = "IBG70CC06";

        /// <summary>
        /// IBG70CC07.
        /// </summary>
        public const string IBG70CC07 = "IBG70CC07";

        /// <summary>
        /// IBG70CC08.
        /// </summary>
        public const string IBG70CC08 = "IBG70CC08";

        /// <summary>
        /// IBG70CC09.
        /// </summary>
        public const string IBG70CC09 = "IBG70CC09";

        /// <summary>
        /// IBG70CC10.
        /// </summary>
        public const string IBG70CC10 = "IBG70CC10";

        /// <summary>
        /// IBURCD.
        /// </summary>
        public const string IBURCD = "IBURCD";

        /// <summary>
        /// IBURDT.
        /// </summary>
        public const string IBURDT = "IBURDT";

        /// <summary>
        /// IBURAT.
        /// </summary>
        public const string IBURAT = "IBURAT";

        /// <summary>
        /// IBURAB.
        /// </summary>
        public const string IBURAB = "IBURAB";

        /// <summary>
        /// IBURRF.
        /// </summary>
        public const string IBURRF = "IBURRF";

        /// <summary>
        /// IBUSER.
        /// </summary>
        public const string IBUSER = "IBUSER";

        /// <summary>
        /// IBPID.
        /// </summary>
        public const string IBPID = "IBPID";

        /// <summary>
        /// IBJOBN.
        /// </summary>
        public const string IBJOBN = "IBJOBN";

        /// <summary>
        /// IBUPMT.
        /// </summary>
        public const string IBUPMT = "IBUPMT";

        /// <summary>
        /// IBUPMJ.
        /// </summary>
        public const string IBUPMJ = "IBUPMJ";
    }

    /// <inheritdoc />
    public override string TableName => "F704102";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("IBITM", "IBITM", JdeDataType.Numeric, null, true, true),
        new JdeField("IBLCTR", "IBLCTR", JdeDataType.String, 6, true, true),
        new JdeField("IBMCU", "IBMCU", JdeDataType.String, 24, true, true),
        new JdeField("IBG70CC01", "IBG70CC01", JdeDataType.String, 20),
        new JdeField("IBG70CC02", "IBG70CC02", JdeDataType.String, 20),
        new JdeField("IBG70CC03", "IBG70CC03", JdeDataType.String, 20),
        new JdeField("IBG70CC04", "IBG70CC04", JdeDataType.String, 20),
        new JdeField("IBG70CC05", "IBG70CC05", JdeDataType.String, 20),
        new JdeField("IBG70CC06", "IBG70CC06", JdeDataType.String, 20),
        new JdeField("IBG70CC07", "IBG70CC07", JdeDataType.String, 20),
        new JdeField("IBG70CC08", "IBG70CC08", JdeDataType.String, 20),
        new JdeField("IBG70CC09", "IBG70CC09", JdeDataType.String, 20),
        new JdeField("IBG70CC10", "IBG70CC10", JdeDataType.String, 20),
        new JdeField("IBURCD", "IBURCD", JdeDataType.String, 4),
        new JdeField("IBURDT", "IBURDT", JdeDataType.Numeric),
        new JdeField("IBURAT", "IBURAT", JdeDataType.Numeric),
        new JdeField("IBURAB", "IBURAB", JdeDataType.Numeric),
        new JdeField("IBURRF", "IBURRF", JdeDataType.String, 30),
        new JdeField("IBUSER", "IBUSER", JdeDataType.String, 20),
        new JdeField("IBPID", "IBPID", JdeDataType.String, 20),
        new JdeField("IBJOBN", "IBJOBN", JdeDataType.String, 20),
        new JdeField("IBUPMT", "IBUPMT", JdeDataType.Numeric),
        new JdeField("IBUPMJ", "IBUPMJ", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F704102_0", "Primary Key on IBLCTR, IBITM, IBMCU", new[] { "IBLCTR", "IBITM", "IBMCU" }, isUnique: true, isPrimaryKey: true)
    };
}
