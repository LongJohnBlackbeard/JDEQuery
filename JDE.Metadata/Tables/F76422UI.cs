using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F76422UI - .
/// </summary>
public class F76422UI : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// WFDOCO.
        /// </summary>
        public const string WFDOCO = "WFDOCO";

        /// <summary>
        /// WFDCTO.
        /// </summary>
        public const string WFDCTO = "WFDCTO";

        /// <summary>
        /// WFKCOO.
        /// </summary>
        public const string WFKCOO = "WFKCOO";

        /// <summary>
        /// WFSFXO.
        /// </summary>
        public const string WFSFXO = "WFSFXO";

        /// <summary>
        /// WFLNID.
        /// </summary>
        public const string WFLNID = "WFLNID";

        /// <summary>
        /// WFBNOP.
        /// </summary>
        public const string WFBNOP = "WFBNOP";

        /// <summary>
        /// WFBSOP.
        /// </summary>
        public const string WFBSOP = "WFBSOP";

        /// <summary>
        /// WFBCTF.
        /// </summary>
        public const string WFBCTF = "WFBCTF";

        /// <summary>
        /// WFBCLF.
        /// </summary>
        public const string WFBCLF = "WFBCLF";

        /// <summary>
        /// WFBIST.
        /// </summary>
        public const string WFBIST = "WFBIST";

        /// <summary>
        /// WFBORI.
        /// </summary>
        public const string WFBORI = "WFBORI";

        /// <summary>
        /// WFBCFC.
        /// </summary>
        public const string WFBCFC = "WFBCFC";

        /// <summary>
        /// WFBINM.
        /// </summary>
        public const string WFBINM = "WFBINM";

        /// <summary>
        /// WFUSER.
        /// </summary>
        public const string WFUSER = "WFUSER";

        /// <summary>
        /// WFPID.
        /// </summary>
        public const string WFPID = "WFPID";

        /// <summary>
        /// WFJOBN.
        /// </summary>
        public const string WFJOBN = "WFJOBN";

        /// <summary>
        /// WFUPMJ.
        /// </summary>
        public const string WFUPMJ = "WFUPMJ";

        /// <summary>
        /// WFTDAY.
        /// </summary>
        public const string WFTDAY = "WFTDAY";
    }

    /// <inheritdoc />
    public override string TableName => "F76422UI";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("WFDOCO", "WFDOCO", JdeDataType.Numeric, null, true, true),
        new JdeField("WFDCTO", "WFDCTO", JdeDataType.String, 4, true, true),
        new JdeField("WFKCOO", "WFKCOO", JdeDataType.String, 10, true, true),
        new JdeField("WFSFXO", "WFSFXO", JdeDataType.String, 6, true, true),
        new JdeField("WFLNID", "WFLNID", JdeDataType.Numeric, null, true, true),
        new JdeField("WFBNOP", "WFBNOP", JdeDataType.Numeric),
        new JdeField("WFBSOP", "WFBSOP", JdeDataType.String, 4),
        new JdeField("WFBCTF", "WFBCTF", JdeDataType.String, 4),
        new JdeField("WFBCLF", "WFBCLF", JdeDataType.String, 20),
        new JdeField("WFBIST", "WFBIST", JdeDataType.String, 2),
        new JdeField("WFBORI", "WFBORI", JdeDataType.String, 2),
        new JdeField("WFBCFC", "WFBCFC", JdeDataType.String, 6),
        new JdeField("WFBINM", "WFBINM", JdeDataType.String, 20),
        new JdeField("WFUSER", "WFUSER", JdeDataType.String, 20),
        new JdeField("WFPID", "WFPID", JdeDataType.String, 20),
        new JdeField("WFJOBN", "WFJOBN", JdeDataType.String, 20),
        new JdeField("WFUPMJ", "WFUPMJ", JdeDataType.Numeric),
        new JdeField("WFTDAY", "WFTDAY", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F76422UI_0", "Primary Key on WFDOCO, WFDCTO, WFKCOO, WFSFXO, WFLNID", new[] { "WFDOCO", "WFDCTO", "WFKCOO", "WFSFXO", "WFLNID" }, isUnique: true, isPrimaryKey: true)
    };
}
