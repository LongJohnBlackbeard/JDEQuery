using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F48S002 - .
/// </summary>
public class F48S002 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// WMICU.
        /// </summary>
        public const string WMICU = "WMICU";

        /// <summary>
        /// WMDOCZ.
        /// </summary>
        public const string WMDOCZ = "WMDOCZ";

        /// <summary>
        /// WMDCTI.
        /// </summary>
        public const string WMDCTI = "WMDCTI";

        /// <summary>
        /// WMKCO.
        /// </summary>
        public const string WMKCO = "WMKCO";

        /// <summary>
        /// WMDOC.
        /// </summary>
        public const string WMDOC = "WMDOC";

        /// <summary>
        /// WMDCT.
        /// </summary>
        public const string WMDCT = "WMDCT";
    }

    /// <inheritdoc />
    public override string TableName => "F48S002";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("WMICU", "WMICU", JdeDataType.Numeric, null, true, true),
        new JdeField("WMDOCZ", "WMDOCZ", JdeDataType.Numeric, null, true, true),
        new JdeField("WMDCTI", "WMDCTI", JdeDataType.String, 4, true, true),
        new JdeField("WMKCO", "WMKCO", JdeDataType.String, 10, true, true),
        new JdeField("WMDOC", "WMDOC", JdeDataType.Numeric),
        new JdeField("WMDCT", "WMDCT", JdeDataType.String, 4)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F48S002_0", "Primary Key on WMICU, WMDOCZ, WMDCTI, WMKCO", new[] { "WMICU", "WMDOCZ", "WMDCTI", "WMKCO" }, isUnique: true, isPrimaryKey: true)
    };
}
