using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F069016T - .
/// </summary>
public class F069016T : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// YPTARA.
        /// </summary>
        public const string YPTARA = "YPTARA";

        /// <summary>
        /// YPPTAX.
        /// </summary>
        public const string YPPTAX = "YPPTAX";

        /// <summary>
        /// YPDSCA.
        /// </summary>
        public const string YPDSCA = "YPDSCA";

        /// <summary>
        /// YPLNGP.
        /// </summary>
        public const string YPLNGP = "YPLNGP";

        /// <summary>
        /// YPUSER.
        /// </summary>
        public const string YPUSER = "YPUSER";

        /// <summary>
        /// YPPID.
        /// </summary>
        public const string YPPID = "YPPID";

        /// <summary>
        /// YPUPMJ.
        /// </summary>
        public const string YPUPMJ = "YPUPMJ";

        /// <summary>
        /// YPJOBN.
        /// </summary>
        public const string YPJOBN = "YPJOBN";

        /// <summary>
        /// YPUPMT.
        /// </summary>
        public const string YPUPMT = "YPUPMT";
    }

    /// <inheritdoc />
    public override string TableName => "F069016T";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("YPTARA", "YPTARA", JdeDataType.String, 20, true, true),
        new JdeField("YPPTAX", "YPPTAX", JdeDataType.String, 4, true, true),
        new JdeField("YPDSCA", "YPDSCA", JdeDataType.String, 80),
        new JdeField("YPLNGP", "YPLNGP", JdeDataType.String, 4),
        new JdeField("YPUSER", "YPUSER", JdeDataType.String, 20),
        new JdeField("YPPID", "YPPID", JdeDataType.String, 20),
        new JdeField("YPUPMJ", "YPUPMJ", JdeDataType.Numeric),
        new JdeField("YPJOBN", "YPJOBN", JdeDataType.String, 20),
        new JdeField("YPUPMT", "YPUPMT", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F069016T_0", "Primary Key on YPTARA, YPPTAX", new[] { "YPTARA", "YPPTAX" }, isUnique: true, isPrimaryKey: true)
    };
}
