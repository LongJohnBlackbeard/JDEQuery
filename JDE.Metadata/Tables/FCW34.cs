using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// FCW34 - .
/// </summary>
public class FCW34 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// PDC9PLN.
        /// </summary>
        public const string PDC9PLN = "PDC9PLN";

        /// <summary>
        /// PDC9LVL0.
        /// </summary>
        public const string PDC9LVL0 = "PDC9LVL0";

        /// <summary>
        /// PDC9LVL1.
        /// </summary>
        public const string PDC9LVL1 = "PDC9LVL1";

        /// <summary>
        /// PDC9LVL2.
        /// </summary>
        public const string PDC9LVL2 = "PDC9LVL2";

        /// <summary>
        /// PDC9LVL3.
        /// </summary>
        public const string PDC9LVL3 = "PDC9LVL3";

        /// <summary>
        /// PDC9LVL4.
        /// </summary>
        public const string PDC9LVL4 = "PDC9LVL4";

        /// <summary>
        /// PDC9LVL5.
        /// </summary>
        public const string PDC9LVL5 = "PDC9LVL5";

        /// <summary>
        /// PDC9LVL6.
        /// </summary>
        public const string PDC9LVL6 = "PDC9LVL6";

        /// <summary>
        /// PDC9LVL7.
        /// </summary>
        public const string PDC9LVL7 = "PDC9LVL7";

        /// <summary>
        /// PDC9LVL8.
        /// </summary>
        public const string PDC9LVL8 = "PDC9LVL8";

        /// <summary>
        /// PDC9LVL9.
        /// </summary>
        public const string PDC9LVL9 = "PDC9LVL9";

        /// <summary>
        /// PDUOM1.
        /// </summary>
        public const string PDUOM1 = "PDUOM1";

        /// <summary>
        /// PDMCU.
        /// </summary>
        public const string PDMCU = "PDMCU";

        /// <summary>
        /// PDLOCN.
        /// </summary>
        public const string PDLOCN = "PDLOCN";

        /// <summary>
        /// PDLOTN.
        /// </summary>
        public const string PDLOTN = "PDLOTN";

        /// <summary>
        /// PDUPRC.
        /// </summary>
        public const string PDUPRC = "PDUPRC";

        /// <summary>
        /// PDACRD.
        /// </summary>
        public const string PDACRD = "PDACRD";

        /// <summary>
        /// PDITM.
        /// </summary>
        public const string PDITM = "PDITM";

        /// <summary>
        /// PDC9STS.
        /// </summary>
        public const string PDC9STS = "PDC9STS";

        /// <summary>
        /// PDC9USER.
        /// </summary>
        public const string PDC9USER = "PDC9USER";

        /// <summary>
        /// PDURCD.
        /// </summary>
        public const string PDURCD = "PDURCD";

        /// <summary>
        /// PDURDT.
        /// </summary>
        public const string PDURDT = "PDURDT";

        /// <summary>
        /// PDURAT.
        /// </summary>
        public const string PDURAT = "PDURAT";

        /// <summary>
        /// PDURAB.
        /// </summary>
        public const string PDURAB = "PDURAB";

        /// <summary>
        /// PDURRF.
        /// </summary>
        public const string PDURRF = "PDURRF";

        /// <summary>
        /// PDUSER.
        /// </summary>
        public const string PDUSER = "PDUSER";

        /// <summary>
        /// PDPID.
        /// </summary>
        public const string PDPID = "PDPID";

        /// <summary>
        /// PDJOBN.
        /// </summary>
        public const string PDJOBN = "PDJOBN";

        /// <summary>
        /// PDUPMJ.
        /// </summary>
        public const string PDUPMJ = "PDUPMJ";

        /// <summary>
        /// PDTDAY.
        /// </summary>
        public const string PDTDAY = "PDTDAY";
    }

    /// <inheritdoc />
    public override string TableName => "FCW34";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("PDC9PLN", "PDC9PLN", JdeDataType.Numeric, null, true, true),
        new JdeField("PDC9LVL0", "PDC9LVL0", JdeDataType.String, 50, true, true),
        new JdeField("PDC9LVL1", "PDC9LVL1", JdeDataType.String, 12, true, true),
        new JdeField("PDC9LVL2", "PDC9LVL2", JdeDataType.String, 12, true, true),
        new JdeField("PDC9LVL3", "PDC9LVL3", JdeDataType.String, 12, true, true),
        new JdeField("PDC9LVL4", "PDC9LVL4", JdeDataType.String, 12, true, true),
        new JdeField("PDC9LVL5", "PDC9LVL5", JdeDataType.String, 12, true, true),
        new JdeField("PDC9LVL6", "PDC9LVL6", JdeDataType.String, 12, true, true),
        new JdeField("PDC9LVL7", "PDC9LVL7", JdeDataType.String, 12, true, true),
        new JdeField("PDC9LVL8", "PDC9LVL8", JdeDataType.String, 12, true, true),
        new JdeField("PDC9LVL9", "PDC9LVL9", JdeDataType.String, 12, true, true),
        new JdeField("PDUOM1", "PDUOM1", JdeDataType.String, 4, true, true),
        new JdeField("PDMCU", "PDMCU", JdeDataType.String, 24, true, true),
        new JdeField("PDLOCN", "PDLOCN", JdeDataType.String, 40, true, true),
        new JdeField("PDLOTN", "PDLOTN", JdeDataType.String, 60, true, true),
        new JdeField("PDUPRC", "PDUPRC", JdeDataType.Numeric),
        new JdeField("PDACRD", "PDACRD", JdeDataType.Numeric),
        new JdeField("PDITM", "PDITM", JdeDataType.Numeric),
        new JdeField("PDC9STS", "PDC9STS", JdeDataType.String, 2),
        new JdeField("PDC9USER", "PDC9USER", JdeDataType.String, 20),
        new JdeField("PDURCD", "PDURCD", JdeDataType.String, 4),
        new JdeField("PDURDT", "PDURDT", JdeDataType.Numeric),
        new JdeField("PDURAT", "PDURAT", JdeDataType.Numeric),
        new JdeField("PDURAB", "PDURAB", JdeDataType.Numeric),
        new JdeField("PDURRF", "PDURRF", JdeDataType.String, 30),
        new JdeField("PDUSER", "PDUSER", JdeDataType.String, 20),
        new JdeField("PDPID", "PDPID", JdeDataType.String, 20),
        new JdeField("PDJOBN", "PDJOBN", JdeDataType.String, 20),
        new JdeField("PDUPMJ", "PDUPMJ", JdeDataType.Numeric),
        new JdeField("PDTDAY", "PDTDAY", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("FCW34_0", "Primary Key on PDC9PLN, PDC9LVL0, PDC9LVL1, PDC9LVL2, PDC9LVL3, PDC9LVL4, PDC9LVL5, PDC9LVL6, PDC9LVL7, PDC9LVL8, PDC9LVL9, PDUOM1, PDMCU, PDLOCN, PDLOTN", new[] { "PDC9PLN", "PDC9LVL0", "PDC9LVL1", "PDC9LVL2", "PDC9LVL3", "PDC9LVL4", "PDC9LVL5", "PDC9LVL6", "PDC9LVL7", "PDC9LVL8", "PDC9LVL9", "PDUOM1", "PDMCU", "PDLOCN", "PDLOTN" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("FCW34_2", "Index on PDC9PLN", new[] { "PDC9PLN" })
    };
}
