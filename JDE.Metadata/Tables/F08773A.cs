using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F08773A - .
/// </summary>
public class F08773A : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// XLTINC.
        /// </summary>
        public const string XLTINC = "XLTINC";

        /// <summary>
        /// XLHMCO.
        /// </summary>
        public const string XLHMCO = "XLHMCO";

        /// <summary>
        /// XLORMCU.
        /// </summary>
        public const string XLORMCU = "XLORMCU";

        /// <summary>
        /// XLMSEB.
        /// </summary>
        public const string XLMSEB = "XLMSEB";

        /// <summary>
        /// XLUSER.
        /// </summary>
        public const string XLUSER = "XLUSER";

        /// <summary>
        /// XLPID.
        /// </summary>
        public const string XLPID = "XLPID";

        /// <summary>
        /// XLJOBN.
        /// </summary>
        public const string XLJOBN = "XLJOBN";

        /// <summary>
        /// XLUPMJ.
        /// </summary>
        public const string XLUPMJ = "XLUPMJ";

        /// <summary>
        /// XLUPMT.
        /// </summary>
        public const string XLUPMT = "XLUPMT";
    }

    /// <inheritdoc />
    public override string TableName => "F08773A";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("XLTINC", "XLTINC", JdeDataType.String, 2, true, true),
        new JdeField("XLHMCO", "XLHMCO", JdeDataType.String, 10, true, true),
        new JdeField("XLORMCU", "XLORMCU", JdeDataType.String, 24, true, true),
        new JdeField("XLMSEB", "XLMSEB", JdeDataType.String, 2),
        new JdeField("XLUSER", "XLUSER", JdeDataType.String, 20),
        new JdeField("XLPID", "XLPID", JdeDataType.String, 20),
        new JdeField("XLJOBN", "XLJOBN", JdeDataType.String, 20),
        new JdeField("XLUPMJ", "XLUPMJ", JdeDataType.Numeric),
        new JdeField("XLUPMT", "XLUPMT", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F08773A_0", "Primary Key on XLTINC, XLHMCO, XLORMCU", new[] { "XLTINC", "XLHMCO", "XLORMCU" }, isUnique: true, isPrimaryKey: true)
    };
}
