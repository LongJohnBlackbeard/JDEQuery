using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F4861 - .
/// </summary>
public class F4861 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// AFCTBL.
        /// </summary>
        public const string AFCTBL = "AFCTBL";

        /// <summary>
        /// AFEFTB.
        /// </summary>
        public const string AFEFTB = "AFEFTB";

        /// <summary>
        /// AFCCOD.
        /// </summary>
        public const string AFCCOD = "AFCCOD";

        /// <summary>
        /// AFSEQ.
        /// </summary>
        public const string AFSEQ = "AFSEQ";

        /// <summary>
        /// AFCRTP.
        /// </summary>
        public const string AFCRTP = "AFCRTP";

        /// <summary>
        /// AFUSER.
        /// </summary>
        public const string AFUSER = "AFUSER";

        /// <summary>
        /// AFPID.
        /// </summary>
        public const string AFPID = "AFPID";

        /// <summary>
        /// AFJOBN.
        /// </summary>
        public const string AFJOBN = "AFJOBN";

        /// <summary>
        /// AFUPMJ.
        /// </summary>
        public const string AFUPMJ = "AFUPMJ";

        /// <summary>
        /// AFUPMT.
        /// </summary>
        public const string AFUPMT = "AFUPMT";

        /// <summary>
        /// AFUORC.
        /// </summary>
        public const string AFUORC = "AFUORC";

        /// <summary>
        /// AFCRCD.
        /// </summary>
        public const string AFCRCD = "AFCRCD";

        /// <summary>
        /// AFUKID.
        /// </summary>
        public const string AFUKID = "AFUKID";
    }

    /// <inheritdoc />
    public override string TableName => "F4861";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("AFCTBL", "AFCTBL", JdeDataType.String, 20, true, true),
        new JdeField("AFEFTB", "AFEFTB", JdeDataType.Numeric, null, true, true),
        new JdeField("AFCCOD", "AFCCOD", JdeDataType.String, 10),
        new JdeField("AFSEQ", "AFSEQ", JdeDataType.Numeric),
        new JdeField("AFCRTP", "AFCRTP", JdeDataType.Numeric),
        new JdeField("AFUSER", "AFUSER", JdeDataType.String, 20),
        new JdeField("AFPID", "AFPID", JdeDataType.String, 20),
        new JdeField("AFJOBN", "AFJOBN", JdeDataType.String, 20),
        new JdeField("AFUPMJ", "AFUPMJ", JdeDataType.Numeric),
        new JdeField("AFUPMT", "AFUPMT", JdeDataType.Numeric),
        new JdeField("AFUORC", "AFUORC", JdeDataType.String, 2),
        new JdeField("AFCRCD", "AFCRCD", JdeDataType.String, 6, true, true),
        new JdeField("AFUKID", "AFUKID", JdeDataType.Numeric, null, true, true)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F4861_0", "Primary Key on AFCTBL, AFCRCD, AFEFTB, AFUKID", new[] { "AFCTBL", "AFCRCD", "AFEFTB", "AFUKID" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F4861_3", "Index on AFCTBL, AFCRCD, AFCCOD", new[] { "AFCTBL", "AFCRCD", "AFCCOD" }),
        new JdeIndex("F4861_4", "Index on AFCTBL, AFCRCD, AFEFTB", new[] { "AFCTBL", "AFCRCD", "AFEFTB" }),
        new JdeIndex("F4861_5", "Index on AFCTBL, AFCRCD, AFEFTB, AFSEQ", new[] { "AFCTBL", "AFCRCD", "AFEFTB", "AFSEQ" })
    };
}
