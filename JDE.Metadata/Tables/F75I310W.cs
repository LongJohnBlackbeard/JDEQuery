using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F75I310W - .
/// </summary>
public class F75I310W : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// REYEXU.
        /// </summary>
        public const string REYEXU = "REYEXU";

        /// <summary>
        /// REDOC.
        /// </summary>
        public const string REDOC = "REDOC";

        /// <summary>
        /// REDCT.
        /// </summary>
        public const string REDCT = "REDCT";

        /// <summary>
        /// REKCO.
        /// </summary>
        public const string REKCO = "REKCO";

        /// <summary>
        /// RESUB.
        /// </summary>
        public const string RESUB = "RESUB";

        /// <summary>
        /// REJELN.
        /// </summary>
        public const string REJELN = "REJELN";

        /// <summary>
        /// REUSER.
        /// </summary>
        public const string REUSER = "REUSER";

        /// <summary>
        /// REPID.
        /// </summary>
        public const string REPID = "REPID";

        /// <summary>
        /// REJOBN.
        /// </summary>
        public const string REJOBN = "REJOBN";

        /// <summary>
        /// REUPMJ.
        /// </summary>
        public const string REUPMJ = "REUPMJ";

        /// <summary>
        /// REUPMT.
        /// </summary>
        public const string REUPMT = "REUPMT";
    }

    /// <inheritdoc />
    public override string TableName => "F75I310W";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("REYEXU", "REYEXU", JdeDataType.Numeric, null, true, true),
        new JdeField("REDOC", "REDOC", JdeDataType.Numeric, null, true, true),
        new JdeField("REDCT", "REDCT", JdeDataType.String, 4, true, true),
        new JdeField("REKCO", "REKCO", JdeDataType.String, 10, true, true),
        new JdeField("RESUB", "RESUB", JdeDataType.String, 16, true, true),
        new JdeField("REJELN", "REJELN", JdeDataType.Numeric, null, true, true),
        new JdeField("REUSER", "REUSER", JdeDataType.String, 20),
        new JdeField("REPID", "REPID", JdeDataType.String, 20),
        new JdeField("REJOBN", "REJOBN", JdeDataType.String, 20),
        new JdeField("REUPMJ", "REUPMJ", JdeDataType.Numeric),
        new JdeField("REUPMT", "REUPMT", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F75I310W_0", "Primary Key on REDOC, REDCT, REKCO, RESUB, REYEXU, REJELN", new[] { "REDOC", "REDCT", "REKCO", "RESUB", "REYEXU", "REJELN" }, isUnique: true, isPrimaryKey: true)
    };
}
