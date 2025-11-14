using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F15703 - .
/// </summary>
public class F15703 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// NIDOCO.
        /// </summary>
        public const string NIDOCO = "NIDOCO";

        /// <summary>
        /// NIAN8.
        /// </summary>
        public const string NIAN8 = "NIAN8";

        /// <summary>
        /// NICLNO.
        /// </summary>
        public const string NICLNO = "NICLNO";

        /// <summary>
        /// NISEQN.
        /// </summary>
        public const string NISEQN = "NISEQN";

        /// <summary>
        /// NIAG.
        /// </summary>
        public const string NIAG = "NIAG";

        /// <summary>
        /// NITYAM.
        /// </summary>
        public const string NITYAM = "NITYAM";

        /// <summary>
        /// NIUM.
        /// </summary>
        public const string NIUM = "NIUM";

        /// <summary>
        /// NIEFTB.
        /// </summary>
        public const string NIEFTB = "NIEFTB";

        /// <summary>
        /// NIEFTE.
        /// </summary>
        public const string NIEFTE = "NIEFTE";

        /// <summary>
        /// NILSVR.
        /// </summary>
        public const string NILSVR = "NILSVR";

        /// <summary>
        /// NIURCD.
        /// </summary>
        public const string NIURCD = "NIURCD";

        /// <summary>
        /// NIURDT.
        /// </summary>
        public const string NIURDT = "NIURDT";

        /// <summary>
        /// NIURAT.
        /// </summary>
        public const string NIURAT = "NIURAT";

        /// <summary>
        /// NIURAB.
        /// </summary>
        public const string NIURAB = "NIURAB";

        /// <summary>
        /// NIURRF.
        /// </summary>
        public const string NIURRF = "NIURRF";

        /// <summary>
        /// NIUSER.
        /// </summary>
        public const string NIUSER = "NIUSER";

        /// <summary>
        /// NIPID.
        /// </summary>
        public const string NIPID = "NIPID";

        /// <summary>
        /// NIUPMJ.
        /// </summary>
        public const string NIUPMJ = "NIUPMJ";

        /// <summary>
        /// NIUPMT.
        /// </summary>
        public const string NIUPMT = "NIUPMT";

        /// <summary>
        /// NIJOBN.
        /// </summary>
        public const string NIJOBN = "NIJOBN";

        /// <summary>
        /// NIENTJ.
        /// </summary>
        public const string NIENTJ = "NIENTJ";

        /// <summary>
        /// NITORG.
        /// </summary>
        public const string NITORG = "NITORG";

        /// <summary>
        /// NICRCD.
        /// </summary>
        public const string NICRCD = "NICRCD";

        /// <summary>
        /// NICRRM.
        /// </summary>
        public const string NICRRM = "NICRRM";
    }

    /// <inheritdoc />
    public override string TableName => "F15703";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("NIDOCO", "NIDOCO", JdeDataType.Numeric, null, true, true),
        new JdeField("NIAN8", "NIAN8", JdeDataType.Numeric, null, true, true),
        new JdeField("NICLNO", "NICLNO", JdeDataType.Numeric, null, true, true),
        new JdeField("NISEQN", "NISEQN", JdeDataType.Numeric, null, true, true),
        new JdeField("NIAG", "NIAG", JdeDataType.Numeric),
        new JdeField("NITYAM", "NITYAM", JdeDataType.String, 8),
        new JdeField("NIUM", "NIUM", JdeDataType.String, 4),
        new JdeField("NIEFTB", "NIEFTB", JdeDataType.Numeric),
        new JdeField("NIEFTE", "NIEFTE", JdeDataType.Numeric),
        new JdeField("NILSVR", "NILSVR", JdeDataType.Numeric),
        new JdeField("NIURCD", "NIURCD", JdeDataType.String, 4),
        new JdeField("NIURDT", "NIURDT", JdeDataType.Numeric),
        new JdeField("NIURAT", "NIURAT", JdeDataType.Numeric),
        new JdeField("NIURAB", "NIURAB", JdeDataType.Numeric),
        new JdeField("NIURRF", "NIURRF", JdeDataType.String, 30),
        new JdeField("NIUSER", "NIUSER", JdeDataType.String, 20),
        new JdeField("NIPID", "NIPID", JdeDataType.String, 20),
        new JdeField("NIUPMJ", "NIUPMJ", JdeDataType.Numeric),
        new JdeField("NIUPMT", "NIUPMT", JdeDataType.Numeric),
        new JdeField("NIJOBN", "NIJOBN", JdeDataType.String, 20),
        new JdeField("NIENTJ", "NIENTJ", JdeDataType.Numeric),
        new JdeField("NITORG", "NITORG", JdeDataType.String, 20),
        new JdeField("NICRCD", "NICRCD", JdeDataType.String, 6),
        new JdeField("NICRRM", "NICRRM", JdeDataType.String, 2)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F15703_0", "Primary Key on NIDOCO, NIAN8, NICLNO, NISEQN", new[] { "NIDOCO", "NIAN8", "NICLNO", "NISEQN" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F15703_2", "Index on NIDOCO, NIAN8, NICLNO, SYS_NC00025$", new[] { "NIDOCO", "NIAN8", "NICLNO", "SYS_NC00025$" }),
        new JdeIndex("F15703_3", "Index on NIDOCO, NIAN8, NICLNO, NILSVR", new[] { "NIDOCO", "NIAN8", "NICLNO", "NILSVR" })
    };
}
