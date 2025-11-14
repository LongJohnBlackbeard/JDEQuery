using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F083303 - .
/// </summary>
public class F083303 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// CRHDCD.
        /// </summary>
        public const string CRHDCD = "CRHDCD";

        /// <summary>
        /// CRHDTY.
        /// </summary>
        public const string CRHDTY = "CRHDTY";

        /// <summary>
        /// CREREE.
        /// </summary>
        public const string CREREE = "CREREE";

        /// <summary>
        /// CRPDBA.
        /// </summary>
        public const string CRPDBA = "CRPDBA";

        /// <summary>
        /// CRTARA.
        /// </summary>
        public const string CRTARA = "CRTARA";

        /// <summary>
        /// CRPTAX.
        /// </summary>
        public const string CRPTAX = "CRPTAX";

        /// <summary>
        /// CRUSER.
        /// </summary>
        public const string CRUSER = "CRUSER";

        /// <summary>
        /// CRPID.
        /// </summary>
        public const string CRPID = "CRPID";

        /// <summary>
        /// CRUPMJ.
        /// </summary>
        public const string CRUPMJ = "CRUPMJ";

        /// <summary>
        /// CRJOBN.
        /// </summary>
        public const string CRJOBN = "CRJOBN";
    }

    /// <inheritdoc />
    public override string TableName => "F083303";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("CRHDCD", "CRHDCD", JdeDataType.String, 20, true, true),
        new JdeField("CRHDTY", "CRHDTY", JdeDataType.String, 2, true, true),
        new JdeField("CREREE", "CREREE", JdeDataType.Numeric),
        new JdeField("CRPDBA", "CRPDBA", JdeDataType.Numeric, null, true, true),
        new JdeField("CRTARA", "CRTARA", JdeDataType.String, 20, true, true),
        new JdeField("CRPTAX", "CRPTAX", JdeDataType.String, 4, true, true),
        new JdeField("CRUSER", "CRUSER", JdeDataType.String, 20),
        new JdeField("CRPID", "CRPID", JdeDataType.String, 20),
        new JdeField("CRUPMJ", "CRUPMJ", JdeDataType.Numeric),
        new JdeField("CRJOBN", "CRJOBN", JdeDataType.String, 20)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F083303_0", "Primary Key on CRHDCD, CRPDBA, CRTARA, CRPTAX, CRHDTY", new[] { "CRHDCD", "CRPDBA", "CRTARA", "CRPTAX", "CRHDTY" }, isUnique: true, isPrimaryKey: true)
    };
}
