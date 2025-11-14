using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F09J20 - .
/// </summary>
public class F09J20 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// JBJVDOI.
        /// </summary>
        public const string JBJVDOI = "JBJVDOI";

        /// <summary>
        /// JBEFTB.
        /// </summary>
        public const string JBEFTB = "JBEFTB";

        /// <summary>
        /// JBJVDID.
        /// </summary>
        public const string JBJVDID = "JBJVDID";

        /// <summary>
        /// JBJVDOIT.
        /// </summary>
        public const string JBJVDOIT = "JBJVDOIT";

        /// <summary>
        /// JBJVDAI.
        /// </summary>
        public const string JBJVDAI = "JBJVDAI";

        /// <summary>
        /// JBJVDPR.
        /// </summary>
        public const string JBJVDPR = "JBJVDPR";

        /// <summary>
        /// JBJVDDE.
        /// </summary>
        public const string JBJVDDE = "JBJVDDE";

        /// <summary>
        /// JBTORG.
        /// </summary>
        public const string JBTORG = "JBTORG";

        /// <summary>
        /// JBENTJ.
        /// </summary>
        public const string JBENTJ = "JBENTJ";

        /// <summary>
        /// JBUSER.
        /// </summary>
        public const string JBUSER = "JBUSER";

        /// <summary>
        /// JBUPMJ.
        /// </summary>
        public const string JBUPMJ = "JBUPMJ";

        /// <summary>
        /// JBUPMT.
        /// </summary>
        public const string JBUPMT = "JBUPMT";

        /// <summary>
        /// JBPID.
        /// </summary>
        public const string JBPID = "JBPID";

        /// <summary>
        /// JBMKEY.
        /// </summary>
        public const string JBMKEY = "JBMKEY";

        /// <summary>
        /// JBURAB.
        /// </summary>
        public const string JBURAB = "JBURAB";

        /// <summary>
        /// JBURCD.
        /// </summary>
        public const string JBURCD = "JBURCD";

        /// <summary>
        /// JBURAT.
        /// </summary>
        public const string JBURAT = "JBURAT";

        /// <summary>
        /// JBURDT.
        /// </summary>
        public const string JBURDT = "JBURDT";

        /// <summary>
        /// JBURRF.
        /// </summary>
        public const string JBURRF = "JBURRF";

        /// <summary>
        /// JBJVHNU1.
        /// </summary>
        public const string JBJVHNU1 = "JBJVHNU1";

        /// <summary>
        /// JBJVHNU2.
        /// </summary>
        public const string JBJVHNU2 = "JBJVHNU2";

        /// <summary>
        /// JBJVHNU3.
        /// </summary>
        public const string JBJVHNU3 = "JBJVHNU3";

        /// <summary>
        /// JBJVHST1.
        /// </summary>
        public const string JBJVHST1 = "JBJVHST1";

        /// <summary>
        /// JBJVHST2.
        /// </summary>
        public const string JBJVHST2 = "JBJVHST2";

        /// <summary>
        /// JBJVHST3.
        /// </summary>
        public const string JBJVHST3 = "JBJVHST3";

        /// <summary>
        /// JBJVHCH1.
        /// </summary>
        public const string JBJVHCH1 = "JBJVHCH1";

        /// <summary>
        /// JBJVHCH2.
        /// </summary>
        public const string JBJVHCH2 = "JBJVHCH2";

        /// <summary>
        /// JBJVHCH3.
        /// </summary>
        public const string JBJVHCH3 = "JBJVHCH3";

        /// <summary>
        /// JBJVHDT1.
        /// </summary>
        public const string JBJVHDT1 = "JBJVHDT1";

        /// <summary>
        /// JBJVHDT2.
        /// </summary>
        public const string JBJVHDT2 = "JBJVHDT2";

        /// <summary>
        /// JBJVHDT3.
        /// </summary>
        public const string JBJVHDT3 = "JBJVHDT3";

        /// <summary>
        /// JBJVDDA.
        /// </summary>
        public const string JBJVDDA = "JBJVDDA";
    }

    /// <inheritdoc />
    public override string TableName => "F09J20";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("JBJVDOI", "JBJVDOI", JdeDataType.String, 40, true, true),
        new JdeField("JBEFTB", "JBEFTB", JdeDataType.Numeric, null, true, true),
        new JdeField("JBJVDID", "JBJVDID", JdeDataType.String, 160),
        new JdeField("JBJVDOIT", "JBJVDOIT", JdeDataType.String, 2),
        new JdeField("JBJVDAI", "JBJVDAI", JdeDataType.String, 2),
        new JdeField("JBJVDPR", "JBJVDPR", JdeDataType.String, 160),
        new JdeField("JBJVDDE", "JBJVDDE", JdeDataType.Numeric),
        new JdeField("JBTORG", "JBTORG", JdeDataType.String, 20),
        new JdeField("JBENTJ", "JBENTJ", JdeDataType.Numeric),
        new JdeField("JBUSER", "JBUSER", JdeDataType.String, 20),
        new JdeField("JBUPMJ", "JBUPMJ", JdeDataType.Numeric),
        new JdeField("JBUPMT", "JBUPMT", JdeDataType.Numeric),
        new JdeField("JBPID", "JBPID", JdeDataType.String, 20),
        new JdeField("JBMKEY", "JBMKEY", JdeDataType.String, 30),
        new JdeField("JBURAB", "JBURAB", JdeDataType.Numeric),
        new JdeField("JBURCD", "JBURCD", JdeDataType.String, 4),
        new JdeField("JBURAT", "JBURAT", JdeDataType.Numeric),
        new JdeField("JBURDT", "JBURDT", JdeDataType.Numeric),
        new JdeField("JBURRF", "JBURRF", JdeDataType.String, 30),
        new JdeField("JBJVHNU1", "JBJVHNU1", JdeDataType.Numeric),
        new JdeField("JBJVHNU2", "JBJVHNU2", JdeDataType.Numeric),
        new JdeField("JBJVHNU3", "JBJVHNU3", JdeDataType.Numeric),
        new JdeField("JBJVHST1", "JBJVHST1", JdeDataType.String, 160),
        new JdeField("JBJVHST2", "JBJVHST2", JdeDataType.String, 160),
        new JdeField("JBJVHST3", "JBJVHST3", JdeDataType.String, 160),
        new JdeField("JBJVHCH1", "JBJVHCH1", JdeDataType.String, 2),
        new JdeField("JBJVHCH2", "JBJVHCH2", JdeDataType.String, 2),
        new JdeField("JBJVHCH3", "JBJVHCH3", JdeDataType.String, 2),
        new JdeField("JBJVHDT1", "JBJVHDT1", JdeDataType.Numeric),
        new JdeField("JBJVHDT2", "JBJVHDT2", JdeDataType.Numeric),
        new JdeField("JBJVHDT3", "JBJVHDT3", JdeDataType.Numeric),
        new JdeField("JBJVDDA", "JBJVDDA", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F09J20_0", "Primary Key on JBJVDOI, JBEFTB", new[] { "JBJVDOI", "JBEFTB" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F09J20_2", "Index on JBJVDOI, JBJVDOIT", new[] { "JBJVDOI", "JBJVDOIT" })
    };
}
