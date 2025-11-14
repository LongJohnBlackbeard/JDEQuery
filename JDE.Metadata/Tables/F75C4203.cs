using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F75C4203 - .
/// </summary>
public class F75C4203 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// FCDOCO.
        /// </summary>
        public const string FCDOCO = "FCDOCO";

        /// <summary>
        /// FCDCTO.
        /// </summary>
        public const string FCDCTO = "FCDCTO";

        /// <summary>
        /// FCKCOO.
        /// </summary>
        public const string FCKCOO = "FCKCOO";

        /// <summary>
        /// FCLNID.
        /// </summary>
        public const string FCLNID = "FCLNID";

        /// <summary>
        /// FCDOC.
        /// </summary>
        public const string FCDOC = "FCDOC";

        /// <summary>
        /// FCDCT.
        /// </summary>
        public const string FCDCT = "FCDCT";

        /// <summary>
        /// FCKCO.
        /// </summary>
        public const string FCKCO = "FCKCO";

        /// <summary>
        /// FCDGJ.
        /// </summary>
        public const string FCDGJ = "FCDGJ";

        /// <summary>
        /// FCICU.
        /// </summary>
        public const string FCICU = "FCICU";

        /// <summary>
        /// FCICUT.
        /// </summary>
        public const string FCICUT = "FCICUT";

        /// <summary>
        /// FCUSER.
        /// </summary>
        public const string FCUSER = "FCUSER";

        /// <summary>
        /// FCPID.
        /// </summary>
        public const string FCPID = "FCPID";

        /// <summary>
        /// FCJOBN.
        /// </summary>
        public const string FCJOBN = "FCJOBN";

        /// <summary>
        /// FCUPMJ.
        /// </summary>
        public const string FCUPMJ = "FCUPMJ";

        /// <summary>
        /// FCUPMT.
        /// </summary>
        public const string FCUPMT = "FCUPMT";
    }

    /// <inheritdoc />
    public override string TableName => "F75C4203";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("FCDOCO", "FCDOCO", JdeDataType.Numeric, null, true, true),
        new JdeField("FCDCTO", "FCDCTO", JdeDataType.String, 4, true, true),
        new JdeField("FCKCOO", "FCKCOO", JdeDataType.String, 10, true, true),
        new JdeField("FCLNID", "FCLNID", JdeDataType.Numeric, null, true, true),
        new JdeField("FCDOC", "FCDOC", JdeDataType.Numeric),
        new JdeField("FCDCT", "FCDCT", JdeDataType.String, 4),
        new JdeField("FCKCO", "FCKCO", JdeDataType.String, 10),
        new JdeField("FCDGJ", "FCDGJ", JdeDataType.Numeric),
        new JdeField("FCICU", "FCICU", JdeDataType.Numeric),
        new JdeField("FCICUT", "FCICUT", JdeDataType.String, 4),
        new JdeField("FCUSER", "FCUSER", JdeDataType.String, 20),
        new JdeField("FCPID", "FCPID", JdeDataType.String, 20),
        new JdeField("FCJOBN", "FCJOBN", JdeDataType.String, 20),
        new JdeField("FCUPMJ", "FCUPMJ", JdeDataType.Numeric),
        new JdeField("FCUPMT", "FCUPMT", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F75C4203_0", "Primary Key on FCDOCO, FCDCTO, FCKCOO, FCLNID", new[] { "FCDOCO", "FCDCTO", "FCKCOO", "FCLNID" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F75C4203_2", "Index on FCICU", new[] { "FCICU" })
    };
}
