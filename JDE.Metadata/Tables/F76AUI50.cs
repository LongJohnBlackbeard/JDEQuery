using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F76AUI50 - .
/// </summary>
public class F76AUI50 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// WFA002.
        /// </summary>
        public const string WFA002 = "WFA002";

        /// <summary>
        /// WFTAX.
        /// </summary>
        public const string WFTAX = "WFTAX";

        /// <summary>
        /// WFUPMJ.
        /// </summary>
        public const string WFUPMJ = "WFUPMJ";

        /// <summary>
        /// WFIN.
        /// </summary>
        public const string WFIN = "WFIN";

        /// <summary>
        /// WFSTA5.
        /// </summary>
        public const string WFSTA5 = "WFSTA5";

        /// <summary>
        /// WFAEXP.
        /// </summary>
        public const string WFAEXP = "WFAEXP";

        /// <summary>
        /// WFATXN.
        /// </summary>
        public const string WFATXN = "WFATXN";

        /// <summary>
        /// WFATXA.
        /// </summary>
        public const string WFATXA = "WFATXA";

        /// <summary>
        /// WFSTAM.
        /// </summary>
        public const string WFSTAM = "WFSTAM";
    }

    /// <inheritdoc />
    public override string TableName => "F76AUI50";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("WFA002", "WFA002", JdeDataType.String, 6, true, true),
        new JdeField("WFTAX", "WFTAX", JdeDataType.String, 40, true, true),
        new JdeField("WFUPMJ", "WFUPMJ", JdeDataType.Numeric, null, true, true),
        new JdeField("WFIN", "WFIN", JdeDataType.String, 24, true, true),
        new JdeField("WFSTA5", "WFSTA5", JdeDataType.Numeric, null, true, true),
        new JdeField("WFAEXP", "WFAEXP", JdeDataType.Numeric, null, true, true),
        new JdeField("WFATXN", "WFATXN", JdeDataType.Numeric, null, true, true),
        new JdeField("WFATXA", "WFATXA", JdeDataType.Numeric, null, true, true),
        new JdeField("WFSTAM", "WFSTAM", JdeDataType.Numeric, null, true, true)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F76AUI50_0", "Primary Key on WFA002, WFTAX, WFUPMJ, WFIN, WFSTA5, WFAEXP, WFATXN, WFATXA, WFSTAM", new[] { "WFA002", "WFTAX", "WFUPMJ", "WFIN", "WFSTA5", "WFAEXP", "WFATXN", "WFATXA", "WFSTAM" }, isUnique: true, isPrimaryKey: true)
    };
}
