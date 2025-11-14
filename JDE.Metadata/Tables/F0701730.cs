using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F0701730 - .
/// </summary>
public class F0701730 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// VSVTFC.
        /// </summary>
        public const string VSVTFC = "VSVTFC";

        /// <summary>
        /// VSTARA.
        /// </summary>
        public const string VSTARA = "VSTARA";

        /// <summary>
        /// VSDESC.
        /// </summary>
        public const string VSDESC = "VSDESC";

        /// <summary>
        /// VSINTEGER.
        /// </summary>
        public const string VSINTEGER = "VSINTEGER";

        /// <summary>
        /// VSUPMJ.
        /// </summary>
        public const string VSUPMJ = "VSUPMJ";

        /// <summary>
        /// VSUPMT.
        /// </summary>
        public const string VSUPMT = "VSUPMT";

        /// <summary>
        /// VSPID.
        /// </summary>
        public const string VSPID = "VSPID";

        /// <summary>
        /// VSJOBN.
        /// </summary>
        public const string VSJOBN = "VSJOBN";

        /// <summary>
        /// VSUSER.
        /// </summary>
        public const string VSUSER = "VSUSER";
    }

    /// <inheritdoc />
    public override string TableName => "F0701730";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("VSVTFC", "VSVTFC", JdeDataType.String, 8, true, true),
        new JdeField("VSTARA", "VSTARA", JdeDataType.String, 20, true, true),
        new JdeField("VSDESC", "VSDESC", JdeDataType.String, 60, true, true),
        new JdeField("VSINTEGER", "VSINTEGER", JdeDataType.Numeric),
        new JdeField("VSUPMJ", "VSUPMJ", JdeDataType.Numeric),
        new JdeField("VSUPMT", "VSUPMT", JdeDataType.Numeric),
        new JdeField("VSPID", "VSPID", JdeDataType.String, 20),
        new JdeField("VSJOBN", "VSJOBN", JdeDataType.String, 20),
        new JdeField("VSUSER", "VSUSER", JdeDataType.String, 20)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F0701730_0", "Primary Key on VSVTFC, VSTARA, VSDESC", new[] { "VSVTFC", "VSTARA", "VSDESC" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F0701730_3", "Index on VSVTFC, VSTARA, VSDESC, VSINTEGER", new[] { "VSVTFC", "VSTARA", "VSDESC", "VSINTEGER" }),
        new JdeIndex("F0701730_4", "Index on VSVTFC, VSTARA, VSINTEGER, VSDESC", new[] { "VSVTFC", "VSTARA", "VSINTEGER", "VSDESC" })
    };
}
