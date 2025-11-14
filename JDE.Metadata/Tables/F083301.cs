using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F083301 - .
/// </summary>
public class F083301 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// BSBSNM.
        /// </summary>
        public const string BSBSNM = "BSBSNM";

        /// <summary>
        /// BSDL01.
        /// </summary>
        public const string BSDL01 = "BSDL01";

        /// <summary>
        /// BSOBNM.
        /// </summary>
        public const string BSOBNM = "BSOBNM";

        /// <summary>
        /// BSUSER.
        /// </summary>
        public const string BSUSER = "BSUSER";

        /// <summary>
        /// BSPID.
        /// </summary>
        public const string BSPID = "BSPID";

        /// <summary>
        /// BSUPMJ.
        /// </summary>
        public const string BSUPMJ = "BSUPMJ";

        /// <summary>
        /// BSJOBN.
        /// </summary>
        public const string BSJOBN = "BSJOBN";
    }

    /// <inheritdoc />
    public override string TableName => "F083301";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("BSBSNM", "BSBSNM", JdeDataType.String, 20, true, true),
        new JdeField("BSDL01", "BSDL01", JdeDataType.String, 60),
        new JdeField("BSOBNM", "BSOBNM", JdeDataType.String, 20),
        new JdeField("BSUSER", "BSUSER", JdeDataType.String, 20),
        new JdeField("BSPID", "BSPID", JdeDataType.String, 20),
        new JdeField("BSUPMJ", "BSUPMJ", JdeDataType.Numeric),
        new JdeField("BSJOBN", "BSJOBN", JdeDataType.String, 20)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F083301_0", "Primary Key on BSBSNM", new[] { "BSBSNM" }, isUnique: true, isPrimaryKey: true)
    };
}
