using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F42X041W - .
/// </summary>
public class F42X041W : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// BRSNKY.
        /// </summary>
        public const string BRSNKY = "BRSNKY";

        /// <summary>
        /// BRAST.
        /// </summary>
        public const string BRAST = "BRAST";

        /// <summary>
        /// BRATID.
        /// </summary>
        public const string BRATID = "BRATID";

        /// <summary>
        /// BRPRGR.
        /// </summary>
        public const string BRPRGR = "BRPRGR";

        /// <summary>
        /// BRDMNQ.
        /// </summary>
        public const string BRDMNQ = "BRDMNQ";

        /// <summary>
        /// BRMNQ.
        /// </summary>
        public const string BRMNQ = "BRMNQ";

        /// <summary>
        /// BRLBT.
        /// </summary>
        public const string BRLBT = "BRLBT";

        /// <summary>
        /// BRUOM.
        /// </summary>
        public const string BRUOM = "BRUOM";

        /// <summary>
        /// BROLVL.
        /// </summary>
        public const string BROLVL = "BROLVL";

        /// <summary>
        /// BRFVTR.
        /// </summary>
        public const string BRFVTR = "BRFVTR";

        /// <summary>
        /// BRCRCD.
        /// </summary>
        public const string BRCRCD = "BRCRCD";

        /// <summary>
        /// BRBSCD.
        /// </summary>
        public const string BRBSCD = "BRBSCD";

        /// <summary>
        /// BRFGY.
        /// </summary>
        public const string BRFGY = "BRFGY";

        /// <summary>
        /// BRAEXP.
        /// </summary>
        public const string BRAEXP = "BRAEXP";

        /// <summary>
        /// BR42XBLFV.
        /// </summary>
        public const string BR42XBLFV = "BR42XBLFV";

        /// <summary>
        /// BR42XAPPLY.
        /// </summary>
        public const string BR42XAPPLY = "BR42XAPPLY";

        /// <summary>
        /// BROSEQ.
        /// </summary>
        public const string BROSEQ = "BROSEQ";

        /// <summary>
        /// BRUSER.
        /// </summary>
        public const string BRUSER = "BRUSER";

        /// <summary>
        /// BRPID.
        /// </summary>
        public const string BRPID = "BRPID";

        /// <summary>
        /// BRJOBN.
        /// </summary>
        public const string BRJOBN = "BRJOBN";

        /// <summary>
        /// BRUPMJ.
        /// </summary>
        public const string BRUPMJ = "BRUPMJ";

        /// <summary>
        /// BRUPMT.
        /// </summary>
        public const string BRUPMT = "BRUPMT";
    }

    /// <inheritdoc />
    public override string TableName => "F42X041W";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("BRSNKY", "BRSNKY", JdeDataType.String, 64, true, true),
        new JdeField("BRAST", "BRAST", JdeDataType.String, 16, true, true),
        new JdeField("BRATID", "BRATID", JdeDataType.Numeric, null, true, true),
        new JdeField("BRPRGR", "BRPRGR", JdeDataType.String, 16),
        new JdeField("BRDMNQ", "BRDMNQ", JdeDataType.Numeric),
        new JdeField("BRMNQ", "BRMNQ", JdeDataType.Numeric),
        new JdeField("BRLBT", "BRLBT", JdeDataType.String, 2),
        new JdeField("BRUOM", "BRUOM", JdeDataType.String, 4),
        new JdeField("BROLVL", "BROLVL", JdeDataType.String, 2),
        new JdeField("BRFVTR", "BRFVTR", JdeDataType.Numeric),
        new JdeField("BRCRCD", "BRCRCD", JdeDataType.String, 6),
        new JdeField("BRBSCD", "BRBSCD", JdeDataType.String, 2),
        new JdeField("BRFGY", "BRFGY", JdeDataType.String, 2),
        new JdeField("BRAEXP", "BRAEXP", JdeDataType.Numeric),
        new JdeField("BR42XBLFV", "BR42XBLFV", JdeDataType.Numeric),
        new JdeField("BR42XAPPLY", "BR42XAPPLY", JdeDataType.String, 2),
        new JdeField("BROSEQ", "BROSEQ", JdeDataType.Numeric),
        new JdeField("BRUSER", "BRUSER", JdeDataType.String, 20),
        new JdeField("BRPID", "BRPID", JdeDataType.String, 20),
        new JdeField("BRJOBN", "BRJOBN", JdeDataType.String, 20),
        new JdeField("BRUPMJ", "BRUPMJ", JdeDataType.Numeric),
        new JdeField("BRUPMT", "BRUPMT", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F42X041W_0", "Primary Key on BRSNKY, BRAST, BRATID", new[] { "BRSNKY", "BRAST", "BRATID" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F42X041W_2", "Index on BRSNKY, BRPRGR, BRLBT, BRDMNQ, BR42XAPPLY", new[] { "BRSNKY", "BRPRGR", "BRLBT", "BRDMNQ", "BR42XAPPLY" }),
        new JdeIndex("F42X041W_3", "Index on BRSNKY, BRPRGR, BRAST, BRDMNQ", new[] { "BRSNKY", "BRPRGR", "BRAST", "BRDMNQ" })
    };
}
