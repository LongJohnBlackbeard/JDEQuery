using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F08336 - .
/// </summary>
public class F08336 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// BJAN8.
        /// </summary>
        public const string BJAN8 = "BJAN8";

        /// <summary>
        /// BJPLAN.
        /// </summary>
        public const string BJPLAN = "BJPLAN";

        /// <summary>
        /// BJAOPT.
        /// </summary>
        public const string BJAOPT = "BJAOPT";

        /// <summary>
        /// BJPAN8.
        /// </summary>
        public const string BJPAN8 = "BJPAN8";

        /// <summary>
        /// BJRELA.
        /// </summary>
        public const string BJRELA = "BJRELA";

        /// <summary>
        /// BJDBEN.
        /// </summary>
        public const string BJDBEN = "BJDBEN";

        /// <summary>
        /// BJDBTY.
        /// </summary>
        public const string BJDBTY = "BJDBTY";

        /// <summary>
        /// BJPERC.
        /// </summary>
        public const string BJPERC = "BJPERC";

        /// <summary>
        /// BJEFT.
        /// </summary>
        public const string BJEFT = "BJEFT";

        /// <summary>
        /// BJEFTE.
        /// </summary>
        public const string BJEFTE = "BJEFTE";

        /// <summary>
        /// BJUSER.
        /// </summary>
        public const string BJUSER = "BJUSER";

        /// <summary>
        /// BJJOBN.
        /// </summary>
        public const string BJJOBN = "BJJOBN";

        /// <summary>
        /// BJUPMJ.
        /// </summary>
        public const string BJUPMJ = "BJUPMJ";
    }

    /// <inheritdoc />
    public override string TableName => "F08336";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("BJAN8", "BJAN8", JdeDataType.Numeric, null, true, true),
        new JdeField("BJPLAN", "BJPLAN", JdeDataType.String, 16, true, true),
        new JdeField("BJAOPT", "BJAOPT", JdeDataType.String, 6, true, true),
        new JdeField("BJPAN8", "BJPAN8", JdeDataType.Numeric, null, true, true),
        new JdeField("BJRELA", "BJRELA", JdeDataType.String, 2),
        new JdeField("BJDBEN", "BJDBEN", JdeDataType.String, 2),
        new JdeField("BJDBTY", "BJDBTY", JdeDataType.String, 4),
        new JdeField("BJPERC", "BJPERC", JdeDataType.Numeric),
        new JdeField("BJEFT", "BJEFT", JdeDataType.Numeric, null, true, true),
        new JdeField("BJEFTE", "BJEFTE", JdeDataType.Numeric),
        new JdeField("BJUSER", "BJUSER", JdeDataType.String, 20),
        new JdeField("BJJOBN", "BJJOBN", JdeDataType.String, 20),
        new JdeField("BJUPMJ", "BJUPMJ", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F08336_0", "Primary Key on BJAN8, BJPLAN, BJAOPT, BJPAN8, BJEFT", new[] { "BJAN8", "BJPLAN", "BJAOPT", "BJPAN8", "BJEFT" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F08336_2", "Index on BJAN8, BJPAN8, BJPLAN, BJAOPT, BJEFT", new[] { "BJAN8", "BJPAN8", "BJPLAN", "BJAOPT", "BJEFT" }),
        new JdeIndex("F08336_3", "Index on BJPAN8, BJAN8, BJPLAN, BJAOPT, BJEFT", new[] { "BJPAN8", "BJAN8", "BJPLAN", "BJAOPT", "BJEFT" }),
        new JdeIndex("F08336_4", "Index on BJAN8, BJPLAN, BJAOPT, BJPAN8, SYS_NC00014$", new[] { "BJAN8", "BJPLAN", "BJAOPT", "BJPAN8", "SYS_NC00014$" }),
        new JdeIndex("F08336_5", "Index on SYS_NC00014$, BJPLAN, BJPAN8", new[] { "SYS_NC00014$", "BJPLAN", "BJPAN8" })
    };
}
