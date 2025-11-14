using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F744102 - .
/// </summary>
public class F744102 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// IBSHCM.
        /// </summary>
        public const string IBSHCM = "IBSHCM";

        /// <summary>
        /// IBCDCD.
        /// </summary>
        public const string IBCDCD = "IBCDCD";

        /// <summary>
        /// IBDL01.
        /// </summary>
        public const string IBDL01 = "IBDL01";

        /// <summary>
        /// IBUOM.
        /// </summary>
        public const string IBUOM = "IBUOM";

        /// <summary>
        /// IBITWT.
        /// </summary>
        public const string IBITWT = "IBITWT";

        /// <summary>
        /// IBYN10.
        /// </summary>
        public const string IBYN10 = "IBYN10";

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
        /// IBUPMJ.
        /// </summary>
        public const string IBUPMJ = "IBUPMJ";

        /// <summary>
        /// IBTDAY.
        /// </summary>
        public const string IBTDAY = "IBTDAY";
    }

    /// <inheritdoc />
    public override string TableName => "F744102";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("IBSHCM", "IBSHCM", JdeDataType.String, 6, true, true),
        new JdeField("IBCDCD", "IBCDCD", JdeDataType.String, 30),
        new JdeField("IBDL01", "IBDL01", JdeDataType.String, 60),
        new JdeField("IBUOM", "IBUOM", JdeDataType.String, 4),
        new JdeField("IBITWT", "IBITWT", JdeDataType.Numeric),
        new JdeField("IBYN10", "IBYN10", JdeDataType.String, 2),
        new JdeField("IBURCD", "IBURCD", JdeDataType.String, 4),
        new JdeField("IBURDT", "IBURDT", JdeDataType.Numeric),
        new JdeField("IBURAT", "IBURAT", JdeDataType.Numeric),
        new JdeField("IBURAB", "IBURAB", JdeDataType.Numeric),
        new JdeField("IBURRF", "IBURRF", JdeDataType.String, 30),
        new JdeField("IBUSER", "IBUSER", JdeDataType.String, 20),
        new JdeField("IBPID", "IBPID", JdeDataType.String, 20),
        new JdeField("IBJOBN", "IBJOBN", JdeDataType.String, 20),
        new JdeField("IBUPMJ", "IBUPMJ", JdeDataType.Numeric),
        new JdeField("IBTDAY", "IBTDAY", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F744102_0", "Primary Key on IBSHCM", new[] { "IBSHCM" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F744102_7", "Index on IBCDCD", new[] { "IBCDCD" })
    };
}
