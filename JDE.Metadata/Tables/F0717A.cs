using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F0717A - .
/// </summary>
public class F0717A : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// JFAN8.
        /// </summary>
        public const string JFAN8 = "JFAN8";

        /// <summary>
        /// JFPCT#.
        /// </summary>
        public const string JFPCT_ = "JFPCT#";

        /// <summary>
        /// JFROEN.
        /// </summary>
        public const string JFROEN = "JFROEN";

        /// <summary>
        /// JFRIROE.
        /// </summary>
        public const string JFRIROE = "JFRIROE";

        /// <summary>
        /// JFVPCD.
        /// </summary>
        public const string JFVPCD = "JFVPCD";

        /// <summary>
        /// JFVCSD.
        /// </summary>
        public const string JFVCSD = "JFVCSD";

        /// <summary>
        /// JFVCEDT.
        /// </summary>
        public const string JFVCEDT = "JFVCEDT";

        /// <summary>
        /// JFHPA4.
        /// </summary>
        public const string JFHPA4 = "JFHPA4";

        /// <summary>
        /// JFHLD4.
        /// </summary>
        public const string JFHLD4 = "JFHLD4";

        /// <summary>
        /// JFHPA5.
        /// </summary>
        public const string JFHPA5 = "JFHPA5";

        /// <summary>
        /// JFHLD5.
        /// </summary>
        public const string JFHLD5 = "JFHLD5";

        /// <summary>
        /// JFHPA6.
        /// </summary>
        public const string JFHPA6 = "JFHPA6";

        /// <summary>
        /// JFHLD6.
        /// </summary>
        public const string JFHLD6 = "JFHLD6";

        /// <summary>
        /// JFHPA7.
        /// </summary>
        public const string JFHPA7 = "JFHPA7";

        /// <summary>
        /// JFHLD7.
        /// </summary>
        public const string JFHLD7 = "JFHLD7";

        /// <summary>
        /// JFHPA8.
        /// </summary>
        public const string JFHPA8 = "JFHPA8";

        /// <summary>
        /// JFHLD8.
        /// </summary>
        public const string JFHLD8 = "JFHLD8";

        /// <summary>
        /// JFHPA9.
        /// </summary>
        public const string JFHPA9 = "JFHPA9";

        /// <summary>
        /// JFHLD9.
        /// </summary>
        public const string JFHLD9 = "JFHLD9";

        /// <summary>
        /// JFHPA10.
        /// </summary>
        public const string JFHPA10 = "JFHPA10";

        /// <summary>
        /// JFHLD10.
        /// </summary>
        public const string JFHLD10 = "JFHLD10";

        /// <summary>
        /// JFOMCD1.
        /// </summary>
        public const string JFOMCD1 = "JFOMCD1";

        /// <summary>
        /// JFOMSD1.
        /// </summary>
        public const string JFOMSD1 = "JFOMSD1";

        /// <summary>
        /// JFOMED1.
        /// </summary>
        public const string JFOMED1 = "JFOMED1";

        /// <summary>
        /// JFOMCD2.
        /// </summary>
        public const string JFOMCD2 = "JFOMCD2";

        /// <summary>
        /// JFOMSD2.
        /// </summary>
        public const string JFOMSD2 = "JFOMSD2";

        /// <summary>
        /// JFOMED2.
        /// </summary>
        public const string JFOMED2 = "JFOMED2";

        /// <summary>
        /// JFOMCD3.
        /// </summary>
        public const string JFOMCD3 = "JFOMCD3";

        /// <summary>
        /// JFOMSD3.
        /// </summary>
        public const string JFOMSD3 = "JFOMSD3";

        /// <summary>
        /// JFOMED3.
        /// </summary>
        public const string JFOMED3 = "JFOMED3";

        /// <summary>
        /// JFSPCD1.
        /// </summary>
        public const string JFSPCD1 = "JFSPCD1";

        /// <summary>
        /// JFSLSD1.
        /// </summary>
        public const string JFSLSD1 = "JFSLSD1";

        /// <summary>
        /// JFSLED1.
        /// </summary>
        public const string JFSLED1 = "JFSLED1";

        /// <summary>
        /// JFSPCD2.
        /// </summary>
        public const string JFSPCD2 = "JFSPCD2";

        /// <summary>
        /// JFSLSD2.
        /// </summary>
        public const string JFSLSD2 = "JFSLSD2";

        /// <summary>
        /// JFSLED2.
        /// </summary>
        public const string JFSLED2 = "JFSLED2";

        /// <summary>
        /// JFNWKP2.
        /// </summary>
        public const string JFNWKP2 = "JFNWKP2";

        /// <summary>
        /// JFNWK#2.
        /// </summary>
        public const string JFNWK_2 = "JFNWK#2";

        /// <summary>
        /// JFSPCD3.
        /// </summary>
        public const string JFSPCD3 = "JFSPCD3";

        /// <summary>
        /// JFSLSD3.
        /// </summary>
        public const string JFSLSD3 = "JFSLSD3";

        /// <summary>
        /// JFSLED3.
        /// </summary>
        public const string JFSLED3 = "JFSLED3";

        /// <summary>
        /// JFNWKP3.
        /// </summary>
        public const string JFNWKP3 = "JFNWKP3";

        /// <summary>
        /// JFNWK#3.
        /// </summary>
        public const string JFNWK_3 = "JFNWK#3";

        /// <summary>
        /// JFSPCD4.
        /// </summary>
        public const string JFSPCD4 = "JFSPCD4";

        /// <summary>
        /// JFSLSD4.
        /// </summary>
        public const string JFSLSD4 = "JFSLSD4";

        /// <summary>
        /// JFSLED4.
        /// </summary>
        public const string JFSLED4 = "JFSLED4";

        /// <summary>
        /// JFNWKP4.
        /// </summary>
        public const string JFNWKP4 = "JFNWKP4";

        /// <summary>
        /// JFNWK#4.
        /// </summary>
        public const string JFNWK_4 = "JFNWK#4";

        /// <summary>
        /// JFSPROES1.
        /// </summary>
        public const string JFSPROES1 = "JFSPROES1";

        /// <summary>
        /// JFSPROES2.
        /// </summary>
        public const string JFSPROES2 = "JFSPROES2";

        /// <summary>
        /// JFSPROES3.
        /// </summary>
        public const string JFSPROES3 = "JFSPROES3";

        /// <summary>
        /// JFSPROES4.
        /// </summary>
        public const string JFSPROES4 = "JFSPROES4";

        /// <summary>
        /// JFSPROEN1.
        /// </summary>
        public const string JFSPROEN1 = "JFSPROEN1";

        /// <summary>
        /// JFSPROEN2.
        /// </summary>
        public const string JFSPROEN2 = "JFSPROEN2";

        /// <summary>
        /// JFSPROEN3.
        /// </summary>
        public const string JFSPROEN3 = "JFSPROEN3";

        /// <summary>
        /// JFSPROEN4.
        /// </summary>
        public const string JFSPROEN4 = "JFSPROEN4";

        /// <summary>
        /// JFSPROED1.
        /// </summary>
        public const string JFSPROED1 = "JFSPROED1";

        /// <summary>
        /// JFSPROED2.
        /// </summary>
        public const string JFSPROED2 = "JFSPROED2";

        /// <summary>
        /// JFSPROED3.
        /// </summary>
        public const string JFSPROED3 = "JFSPROED3";

        /// <summary>
        /// JFSPROED4.
        /// </summary>
        public const string JFSPROED4 = "JFSPROED4";

        /// <summary>
        /// JFSPROED5.
        /// </summary>
        public const string JFSPROED5 = "JFSPROED5";

        /// <summary>
        /// JFSPROED6.
        /// </summary>
        public const string JFSPROED6 = "JFSPROED6";

        /// <summary>
        /// JFSPROED7.
        /// </summary>
        public const string JFSPROED7 = "JFSPROED7";

        /// <summary>
        /// JFSPROED8.
        /// </summary>
        public const string JFSPROED8 = "JFSPROED8";

        /// <summary>
        /// JFSPROEC1.
        /// </summary>
        public const string JFSPROEC1 = "JFSPROEC1";

        /// <summary>
        /// JFSPROEC2.
        /// </summary>
        public const string JFSPROEC2 = "JFSPROEC2";

        /// <summary>
        /// JFSPROEC3.
        /// </summary>
        public const string JFSPROEC3 = "JFSPROEC3";

        /// <summary>
        /// JFSPROEC4.
        /// </summary>
        public const string JFSPROEC4 = "JFSPROEC4";

        /// <summary>
        /// JFUSER.
        /// </summary>
        public const string JFUSER = "JFUSER";

        /// <summary>
        /// JFPID.
        /// </summary>
        public const string JFPID = "JFPID";

        /// <summary>
        /// JFJOBN.
        /// </summary>
        public const string JFJOBN = "JFJOBN";

        /// <summary>
        /// JFUPMJ.
        /// </summary>
        public const string JFUPMJ = "JFUPMJ";

        /// <summary>
        /// JFDTSP.
        /// </summary>
        public const string JFDTSP = "JFDTSP";
    }

    /// <inheritdoc />
    public override string TableName => "F0717A";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("JFAN8", "JFAN8", JdeDataType.Numeric, null, true, true),
        new JdeField("JFPCT#", "JFPCT#", JdeDataType.Numeric, null, true, true),
        new JdeField("JFROEN", "JFROEN", JdeDataType.String, 22, true, true),
        new JdeField("JFRIROE", "JFRIROE", JdeDataType.String, 6),
        new JdeField("JFVPCD", "JFVPCD", JdeDataType.String, 2),
        new JdeField("JFVCSD", "JFVCSD", JdeDataType.Numeric),
        new JdeField("JFVCEDT", "JFVCEDT", JdeDataType.Numeric),
        new JdeField("JFHPA4", "JFHPA4", JdeDataType.Numeric),
        new JdeField("JFHLD4", "JFHLD4", JdeDataType.Numeric),
        new JdeField("JFHPA5", "JFHPA5", JdeDataType.Numeric),
        new JdeField("JFHLD5", "JFHLD5", JdeDataType.Numeric),
        new JdeField("JFHPA6", "JFHPA6", JdeDataType.Numeric),
        new JdeField("JFHLD6", "JFHLD6", JdeDataType.Numeric),
        new JdeField("JFHPA7", "JFHPA7", JdeDataType.Numeric),
        new JdeField("JFHLD7", "JFHLD7", JdeDataType.Numeric),
        new JdeField("JFHPA8", "JFHPA8", JdeDataType.Numeric),
        new JdeField("JFHLD8", "JFHLD8", JdeDataType.Numeric),
        new JdeField("JFHPA9", "JFHPA9", JdeDataType.Numeric),
        new JdeField("JFHLD9", "JFHLD9", JdeDataType.Numeric),
        new JdeField("JFHPA10", "JFHPA10", JdeDataType.Numeric),
        new JdeField("JFHLD10", "JFHLD10", JdeDataType.Numeric),
        new JdeField("JFOMCD1", "JFOMCD1", JdeDataType.String, 6),
        new JdeField("JFOMSD1", "JFOMSD1", JdeDataType.Numeric),
        new JdeField("JFOMED1", "JFOMED1", JdeDataType.Numeric),
        new JdeField("JFOMCD2", "JFOMCD2", JdeDataType.String, 6),
        new JdeField("JFOMSD2", "JFOMSD2", JdeDataType.Numeric),
        new JdeField("JFOMED2", "JFOMED2", JdeDataType.Numeric),
        new JdeField("JFOMCD3", "JFOMCD3", JdeDataType.String, 6),
        new JdeField("JFOMSD3", "JFOMSD3", JdeDataType.Numeric),
        new JdeField("JFOMED3", "JFOMED3", JdeDataType.Numeric),
        new JdeField("JFSPCD1", "JFSPCD1", JdeDataType.String, 10),
        new JdeField("JFSLSD1", "JFSLSD1", JdeDataType.Numeric),
        new JdeField("JFSLED1", "JFSLED1", JdeDataType.Numeric),
        new JdeField("JFSPCD2", "JFSPCD2", JdeDataType.String, 10),
        new JdeField("JFSLSD2", "JFSLSD2", JdeDataType.Numeric),
        new JdeField("JFSLED2", "JFSLED2", JdeDataType.Numeric),
        new JdeField("JFNWKP2", "JFNWKP2", JdeDataType.Numeric),
        new JdeField("JFNWK#2", "JFNWK#2", JdeDataType.Numeric),
        new JdeField("JFSPCD3", "JFSPCD3", JdeDataType.String, 10),
        new JdeField("JFSLSD3", "JFSLSD3", JdeDataType.Numeric),
        new JdeField("JFSLED3", "JFSLED3", JdeDataType.Numeric),
        new JdeField("JFNWKP3", "JFNWKP3", JdeDataType.Numeric),
        new JdeField("JFNWK#3", "JFNWK#3", JdeDataType.Numeric),
        new JdeField("JFSPCD4", "JFSPCD4", JdeDataType.String, 10),
        new JdeField("JFSLSD4", "JFSLSD4", JdeDataType.Numeric),
        new JdeField("JFSLED4", "JFSLED4", JdeDataType.Numeric),
        new JdeField("JFNWKP4", "JFNWKP4", JdeDataType.Numeric),
        new JdeField("JFNWK#4", "JFNWK#4", JdeDataType.Numeric),
        new JdeField("JFSPROES1", "JFSPROES1", JdeDataType.String, 20),
        new JdeField("JFSPROES2", "JFSPROES2", JdeDataType.String, 20),
        new JdeField("JFSPROES3", "JFSPROES3", JdeDataType.String, 20),
        new JdeField("JFSPROES4", "JFSPROES4", JdeDataType.String, 20),
        new JdeField("JFSPROEN1", "JFSPROEN1", JdeDataType.Numeric),
        new JdeField("JFSPROEN2", "JFSPROEN2", JdeDataType.Numeric),
        new JdeField("JFSPROEN3", "JFSPROEN3", JdeDataType.Numeric),
        new JdeField("JFSPROEN4", "JFSPROEN4", JdeDataType.Numeric),
        new JdeField("JFSPROED1", "JFSPROED1", JdeDataType.Numeric),
        new JdeField("JFSPROED2", "JFSPROED2", JdeDataType.Numeric),
        new JdeField("JFSPROED3", "JFSPROED3", JdeDataType.Numeric),
        new JdeField("JFSPROED4", "JFSPROED4", JdeDataType.Numeric),
        new JdeField("JFSPROED5", "JFSPROED5", JdeDataType.Numeric),
        new JdeField("JFSPROED6", "JFSPROED6", JdeDataType.Numeric),
        new JdeField("JFSPROED7", "JFSPROED7", JdeDataType.Numeric),
        new JdeField("JFSPROED8", "JFSPROED8", JdeDataType.Numeric),
        new JdeField("JFSPROEC1", "JFSPROEC1", JdeDataType.String, 2),
        new JdeField("JFSPROEC2", "JFSPROEC2", JdeDataType.String, 2),
        new JdeField("JFSPROEC3", "JFSPROEC3", JdeDataType.String, 2),
        new JdeField("JFSPROEC4", "JFSPROEC4", JdeDataType.String, 2),
        new JdeField("JFUSER", "JFUSER", JdeDataType.String, 20),
        new JdeField("JFPID", "JFPID", JdeDataType.String, 20),
        new JdeField("JFJOBN", "JFJOBN", JdeDataType.String, 20),
        new JdeField("JFUPMJ", "JFUPMJ", JdeDataType.Numeric),
        new JdeField("JFDTSP", "JFDTSP", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F0717A_0", "Primary Key on JFAN8, JFPCT#, JFROEN", new[] { "JFAN8", "JFPCT#", "JFROEN" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F0717A_2", "Index on JFAN8, JFPCT#", new[] { "JFAN8", "JFPCT#" }),
        new JdeIndex("F0717A_3", "Index on JFAN8, JFROEN", new[] { "JFAN8", "JFROEN" })
    };
}
