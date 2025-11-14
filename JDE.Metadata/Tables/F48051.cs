using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F48051 - .
/// </summary>
public class F48051 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// WKSBSK.
        /// </summary>
        public const string WKSBSK = "WKSBSK";

        /// <summary>
        /// WKDTAI.
        /// </summary>
        public const string WKDTAI = "WKDTAI";

        /// <summary>
        /// WKDTAS.
        /// </summary>
        public const string WKDTAS = "WKDTAS";

        /// <summary>
        /// WKLIN.
        /// </summary>
        public const string WKLIN = "WKLIN";

        /// <summary>
        /// WKSBSC.
        /// </summary>
        public const string WKSBSC = "WKSBSC";

        /// <summary>
        /// WKUSER.
        /// </summary>
        public const string WKUSER = "WKUSER";

        /// <summary>
        /// WKPID.
        /// </summary>
        public const string WKPID = "WKPID";

        /// <summary>
        /// WKJOBN.
        /// </summary>
        public const string WKJOBN = "WKJOBN";

        /// <summary>
        /// WKUPMJ.
        /// </summary>
        public const string WKUPMJ = "WKUPMJ";

        /// <summary>
        /// WKUPMT.
        /// </summary>
        public const string WKUPMT = "WKUPMT";
    }

    /// <inheritdoc />
    public override string TableName => "F48051";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("WKSBSK", "WKSBSK", JdeDataType.String, 8, true, true),
        new JdeField("WKDTAI", "WKDTAI", JdeDataType.String, 20),
        new JdeField("WKDTAS", "WKDTAS", JdeDataType.Numeric),
        new JdeField("WKLIN", "WKLIN", JdeDataType.Numeric, null, true, true),
        new JdeField("WKSBSC", "WKSBSC", JdeDataType.String, 2),
        new JdeField("WKUSER", "WKUSER", JdeDataType.String, 20),
        new JdeField("WKPID", "WKPID", JdeDataType.String, 20),
        new JdeField("WKJOBN", "WKJOBN", JdeDataType.String, 20),
        new JdeField("WKUPMJ", "WKUPMJ", JdeDataType.Numeric),
        new JdeField("WKUPMT", "WKUPMT", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F48051_0", "Primary Key on WKSBSK, WKLIN", new[] { "WKSBSK", "WKLIN" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F48051_2", "Index on WKDTAI, WKSBSK, WKLIN", new[] { "WKDTAI", "WKSBSK", "WKLIN" })
    };
}
