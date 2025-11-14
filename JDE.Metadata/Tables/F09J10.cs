using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F09J10 - .
/// </summary>
public class F09J10 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// JAAN8.
        /// </summary>
        public const string JAAN8 = "JAAN8";

        /// <summary>
        /// JAEFTB.
        /// </summary>
        public const string JAEFTB = "JAEFTB";

        /// <summary>
        /// JAJVLN.
        /// </summary>
        public const string JAJVLN = "JAJVLN";

        /// <summary>
        /// JAJVLP.
        /// </summary>
        public const string JAJVLP = "JAJVLP";

        /// <summary>
        /// JAUSER.
        /// </summary>
        public const string JAUSER = "JAUSER";

        /// <summary>
        /// JAUPMJ.
        /// </summary>
        public const string JAUPMJ = "JAUPMJ";

        /// <summary>
        /// JAUPMT.
        /// </summary>
        public const string JAUPMT = "JAUPMT";

        /// <summary>
        /// JAPID.
        /// </summary>
        public const string JAPID = "JAPID";

        /// <summary>
        /// JAMKEY.
        /// </summary>
        public const string JAMKEY = "JAMKEY";

        /// <summary>
        /// JAURAB.
        /// </summary>
        public const string JAURAB = "JAURAB";

        /// <summary>
        /// JAURCD.
        /// </summary>
        public const string JAURCD = "JAURCD";

        /// <summary>
        /// JAURAT.
        /// </summary>
        public const string JAURAT = "JAURAT";

        /// <summary>
        /// JAURDT.
        /// </summary>
        public const string JAURDT = "JAURDT";

        /// <summary>
        /// JAURRF.
        /// </summary>
        public const string JAURRF = "JAURRF";

        /// <summary>
        /// JAURST.
        /// </summary>
        public const string JAURST = "JAURST";

        /// <summary>
        /// JAJVLNU1.
        /// </summary>
        public const string JAJVLNU1 = "JAJVLNU1";

        /// <summary>
        /// JAJVLNU2.
        /// </summary>
        public const string JAJVLNU2 = "JAJVLNU2";

        /// <summary>
        /// JAJVLNU3.
        /// </summary>
        public const string JAJVLNU3 = "JAJVLNU3";

        /// <summary>
        /// JAJVLST1.
        /// </summary>
        public const string JAJVLST1 = "JAJVLST1";

        /// <summary>
        /// JAJVLST2.
        /// </summary>
        public const string JAJVLST2 = "JAJVLST2";

        /// <summary>
        /// JAJVLST3.
        /// </summary>
        public const string JAJVLST3 = "JAJVLST3";

        /// <summary>
        /// JAJVLCH1.
        /// </summary>
        public const string JAJVLCH1 = "JAJVLCH1";

        /// <summary>
        /// JAJVLCH2.
        /// </summary>
        public const string JAJVLCH2 = "JAJVLCH2";

        /// <summary>
        /// JAJVLCH3.
        /// </summary>
        public const string JAJVLCH3 = "JAJVLCH3";

        /// <summary>
        /// JAJVLDT1.
        /// </summary>
        public const string JAJVLDT1 = "JAJVLDT1";

        /// <summary>
        /// JAJVLDT2.
        /// </summary>
        public const string JAJVLDT2 = "JAJVLDT2";

        /// <summary>
        /// JAJVLDT3.
        /// </summary>
        public const string JAJVLDT3 = "JAJVLDT3";

        /// <summary>
        /// JATORG.
        /// </summary>
        public const string JATORG = "JATORG";

        /// <summary>
        /// JAENTJ.
        /// </summary>
        public const string JAENTJ = "JAENTJ";

        /// <summary>
        /// JAJVMIN.
        /// </summary>
        public const string JAJVMIN = "JAJVMIN";

        /// <summary>
        /// JAJVET.
        /// </summary>
        public const string JAJVET = "JAJVET";

        /// <summary>
        /// JAJVMINV.
        /// </summary>
        public const string JAJVMINV = "JAJVMINV";

        /// <summary>
        /// JAJIPTC.
        /// </summary>
        public const string JAJIPTC = "JAJIPTC";

        /// <summary>
        /// JAJVPTC.
        /// </summary>
        public const string JAJVPTC = "JAJVPTC";
    }

    /// <inheritdoc />
    public override string TableName => "F09J10";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("JAAN8", "JAAN8", JdeDataType.Numeric, null, true, true),
        new JdeField("JAEFTB", "JAEFTB", JdeDataType.Numeric, null, true, true),
        new JdeField("JAJVLN", "JAJVLN", JdeDataType.String, 160),
        new JdeField("JAJVLP", "JAJVLP", JdeDataType.String, 2),
        new JdeField("JAUSER", "JAUSER", JdeDataType.String, 20),
        new JdeField("JAUPMJ", "JAUPMJ", JdeDataType.Numeric),
        new JdeField("JAUPMT", "JAUPMT", JdeDataType.Numeric),
        new JdeField("JAPID", "JAPID", JdeDataType.String, 20),
        new JdeField("JAMKEY", "JAMKEY", JdeDataType.String, 30),
        new JdeField("JAURAB", "JAURAB", JdeDataType.Numeric),
        new JdeField("JAURCD", "JAURCD", JdeDataType.String, 4),
        new JdeField("JAURAT", "JAURAT", JdeDataType.Numeric),
        new JdeField("JAURDT", "JAURDT", JdeDataType.Numeric),
        new JdeField("JAURRF", "JAURRF", JdeDataType.String, 30),
        new JdeField("JAURST", "JAURST", JdeDataType.String, 160),
        new JdeField("JAJVLNU1", "JAJVLNU1", JdeDataType.Numeric),
        new JdeField("JAJVLNU2", "JAJVLNU2", JdeDataType.Numeric),
        new JdeField("JAJVLNU3", "JAJVLNU3", JdeDataType.Numeric),
        new JdeField("JAJVLST1", "JAJVLST1", JdeDataType.String, 160),
        new JdeField("JAJVLST2", "JAJVLST2", JdeDataType.String, 160),
        new JdeField("JAJVLST3", "JAJVLST3", JdeDataType.String, 160),
        new JdeField("JAJVLCH1", "JAJVLCH1", JdeDataType.String, 2),
        new JdeField("JAJVLCH2", "JAJVLCH2", JdeDataType.String, 2),
        new JdeField("JAJVLCH3", "JAJVLCH3", JdeDataType.String, 2),
        new JdeField("JAJVLDT1", "JAJVLDT1", JdeDataType.Numeric),
        new JdeField("JAJVLDT2", "JAJVLDT2", JdeDataType.Numeric),
        new JdeField("JAJVLDT3", "JAJVLDT3", JdeDataType.Numeric),
        new JdeField("JATORG", "JATORG", JdeDataType.String, 20),
        new JdeField("JAENTJ", "JAENTJ", JdeDataType.Numeric),
        new JdeField("JAJVMIN", "JAJVMIN", JdeDataType.Numeric),
        new JdeField("JAJVET", "JAJVET", JdeDataType.String, 6),
        new JdeField("JAJVMINV", "JAJVMINV", JdeDataType.Numeric),
        new JdeField("JAJIPTC", "JAJIPTC", JdeDataType.String, 6),
        new JdeField("JAJVPTC", "JAJVPTC", JdeDataType.String, 6)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F09J10_0", "Primary Key on JAAN8, JAEFTB", new[] { "JAAN8", "JAEFTB" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F09J10_2", "Index on JAJVLN, SYS_NC00035$", new[] { "JAJVLN", "SYS_NC00035$" })
    };
}
