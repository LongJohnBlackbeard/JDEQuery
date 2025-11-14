using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F09J60 - .
/// </summary>
public class F09J60 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// EIJVEIX.
        /// </summary>
        public const string EIJVEIX = "EIJVEIX";

        /// <summary>
        /// EICALYEAR.
        /// </summary>
        public const string EICALYEAR = "EICALYEAR";

        /// <summary>
        /// EIJVDL01.
        /// </summary>
        public const string EIJVDL01 = "EIJVDL01";

        /// <summary>
        /// EIJVIX01.
        /// </summary>
        public const string EIJVIX01 = "EIJVIX01";

        /// <summary>
        /// EIJVIX02.
        /// </summary>
        public const string EIJVIX02 = "EIJVIX02";

        /// <summary>
        /// EIJVIX03.
        /// </summary>
        public const string EIJVIX03 = "EIJVIX03";

        /// <summary>
        /// EIJVIX04.
        /// </summary>
        public const string EIJVIX04 = "EIJVIX04";

        /// <summary>
        /// EIJVIX05.
        /// </summary>
        public const string EIJVIX05 = "EIJVIX05";

        /// <summary>
        /// EIJVIX06.
        /// </summary>
        public const string EIJVIX06 = "EIJVIX06";

        /// <summary>
        /// EIJVIX07.
        /// </summary>
        public const string EIJVIX07 = "EIJVIX07";

        /// <summary>
        /// EIJVIX08.
        /// </summary>
        public const string EIJVIX08 = "EIJVIX08";

        /// <summary>
        /// EIJVIX09.
        /// </summary>
        public const string EIJVIX09 = "EIJVIX09";

        /// <summary>
        /// EIJVIX10.
        /// </summary>
        public const string EIJVIX10 = "EIJVIX10";

        /// <summary>
        /// EIJVIX11.
        /// </summary>
        public const string EIJVIX11 = "EIJVIX11";

        /// <summary>
        /// EIJVIX12.
        /// </summary>
        public const string EIJVIX12 = "EIJVIX12";

        /// <summary>
        /// EITORG.
        /// </summary>
        public const string EITORG = "EITORG";

        /// <summary>
        /// EIENTJ.
        /// </summary>
        public const string EIENTJ = "EIENTJ";

        /// <summary>
        /// EIUSER.
        /// </summary>
        public const string EIUSER = "EIUSER";

        /// <summary>
        /// EIUPMJ.
        /// </summary>
        public const string EIUPMJ = "EIUPMJ";

        /// <summary>
        /// EIUPMT.
        /// </summary>
        public const string EIUPMT = "EIUPMT";

        /// <summary>
        /// EIPID.
        /// </summary>
        public const string EIPID = "EIPID";

        /// <summary>
        /// EIMKEY.
        /// </summary>
        public const string EIMKEY = "EIMKEY";

        /// <summary>
        /// EIJVNNU1.
        /// </summary>
        public const string EIJVNNU1 = "EIJVNNU1";

        /// <summary>
        /// EIJVNNU2.
        /// </summary>
        public const string EIJVNNU2 = "EIJVNNU2";

        /// <summary>
        /// EIJVNNU3.
        /// </summary>
        public const string EIJVNNU3 = "EIJVNNU3";

        /// <summary>
        /// EIJVNST1.
        /// </summary>
        public const string EIJVNST1 = "EIJVNST1";

        /// <summary>
        /// EIJVNST2.
        /// </summary>
        public const string EIJVNST2 = "EIJVNST2";

        /// <summary>
        /// EIJVNST3.
        /// </summary>
        public const string EIJVNST3 = "EIJVNST3";

        /// <summary>
        /// EIJVNCH1.
        /// </summary>
        public const string EIJVNCH1 = "EIJVNCH1";

        /// <summary>
        /// EIJVNCH2.
        /// </summary>
        public const string EIJVNCH2 = "EIJVNCH2";

        /// <summary>
        /// EIJVNCH3.
        /// </summary>
        public const string EIJVNCH3 = "EIJVNCH3";

        /// <summary>
        /// EIJVNDT1.
        /// </summary>
        public const string EIJVNDT1 = "EIJVNDT1";

        /// <summary>
        /// EIJVNDT2.
        /// </summary>
        public const string EIJVNDT2 = "EIJVNDT2";

        /// <summary>
        /// EIJVNDT3.
        /// </summary>
        public const string EIJVNDT3 = "EIJVNDT3";

        /// <summary>
        /// EIURATE01.
        /// </summary>
        public const string EIURATE01 = "EIURATE01";

        /// <summary>
        /// EIURATE02.
        /// </summary>
        public const string EIURATE02 = "EIURATE02";

        /// <summary>
        /// EIURATE03.
        /// </summary>
        public const string EIURATE03 = "EIURATE03";

        /// <summary>
        /// EIURATE04.
        /// </summary>
        public const string EIURATE04 = "EIURATE04";

        /// <summary>
        /// EIURATE05.
        /// </summary>
        public const string EIURATE05 = "EIURATE05";

        /// <summary>
        /// EIURCDE01.
        /// </summary>
        public const string EIURCDE01 = "EIURCDE01";

        /// <summary>
        /// EIURCDE02.
        /// </summary>
        public const string EIURCDE02 = "EIURCDE02";

        /// <summary>
        /// EIURCDE03.
        /// </summary>
        public const string EIURCDE03 = "EIURCDE03";

        /// <summary>
        /// EIURCDE04.
        /// </summary>
        public const string EIURCDE04 = "EIURCDE04";

        /// <summary>
        /// EIURCDE05.
        /// </summary>
        public const string EIURCDE05 = "EIURCDE05";

        /// <summary>
        /// EIURDTE01.
        /// </summary>
        public const string EIURDTE01 = "EIURDTE01";

        /// <summary>
        /// EIURDTE02.
        /// </summary>
        public const string EIURDTE02 = "EIURDTE02";

        /// <summary>
        /// EIURDTE03.
        /// </summary>
        public const string EIURDTE03 = "EIURDTE03";

        /// <summary>
        /// EIURDTE04.
        /// </summary>
        public const string EIURDTE04 = "EIURDTE04";

        /// <summary>
        /// EIURDTE05.
        /// </summary>
        public const string EIURDTE05 = "EIURDTE05";

        /// <summary>
        /// EIURNUME01.
        /// </summary>
        public const string EIURNUME01 = "EIURNUME01";

        /// <summary>
        /// EIURNUME02.
        /// </summary>
        public const string EIURNUME02 = "EIURNUME02";

        /// <summary>
        /// EIURNUME03.
        /// </summary>
        public const string EIURNUME03 = "EIURNUME03";

        /// <summary>
        /// EIURNUME04.
        /// </summary>
        public const string EIURNUME04 = "EIURNUME04";

        /// <summary>
        /// EIURNUME05.
        /// </summary>
        public const string EIURNUME05 = "EIURNUME05";

        /// <summary>
        /// EIURRFE01.
        /// </summary>
        public const string EIURRFE01 = "EIURRFE01";

        /// <summary>
        /// EIURRFE02.
        /// </summary>
        public const string EIURRFE02 = "EIURRFE02";

        /// <summary>
        /// EIURRFE03.
        /// </summary>
        public const string EIURRFE03 = "EIURRFE03";

        /// <summary>
        /// EIURRFE04.
        /// </summary>
        public const string EIURRFE04 = "EIURRFE04";

        /// <summary>
        /// EIURRFE05.
        /// </summary>
        public const string EIURRFE05 = "EIURRFE05";

        /// <summary>
        /// EIURSTE01.
        /// </summary>
        public const string EIURSTE01 = "EIURSTE01";

        /// <summary>
        /// EIURSTE02.
        /// </summary>
        public const string EIURSTE02 = "EIURSTE02";

        /// <summary>
        /// EIURSTE03.
        /// </summary>
        public const string EIURSTE03 = "EIURSTE03";

        /// <summary>
        /// EIURSTE04.
        /// </summary>
        public const string EIURSTE04 = "EIURSTE04";

        /// <summary>
        /// EIURSTE05.
        /// </summary>
        public const string EIURSTE05 = "EIURSTE05";
    }

    /// <inheritdoc />
    public override string TableName => "F09J60";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("EIJVEIX", "EIJVEIX", JdeDataType.String, 10, true, true),
        new JdeField("EICALYEAR", "EICALYEAR", JdeDataType.Numeric, null, true, true),
        new JdeField("EIJVDL01", "EIJVDL01", JdeDataType.String, 160),
        new JdeField("EIJVIX01", "EIJVIX01", JdeDataType.Numeric),
        new JdeField("EIJVIX02", "EIJVIX02", JdeDataType.Numeric),
        new JdeField("EIJVIX03", "EIJVIX03", JdeDataType.Numeric),
        new JdeField("EIJVIX04", "EIJVIX04", JdeDataType.Numeric),
        new JdeField("EIJVIX05", "EIJVIX05", JdeDataType.Numeric),
        new JdeField("EIJVIX06", "EIJVIX06", JdeDataType.Numeric),
        new JdeField("EIJVIX07", "EIJVIX07", JdeDataType.Numeric),
        new JdeField("EIJVIX08", "EIJVIX08", JdeDataType.Numeric),
        new JdeField("EIJVIX09", "EIJVIX09", JdeDataType.Numeric),
        new JdeField("EIJVIX10", "EIJVIX10", JdeDataType.Numeric),
        new JdeField("EIJVIX11", "EIJVIX11", JdeDataType.Numeric),
        new JdeField("EIJVIX12", "EIJVIX12", JdeDataType.Numeric),
        new JdeField("EITORG", "EITORG", JdeDataType.String, 20),
        new JdeField("EIENTJ", "EIENTJ", JdeDataType.Numeric),
        new JdeField("EIUSER", "EIUSER", JdeDataType.String, 20),
        new JdeField("EIUPMJ", "EIUPMJ", JdeDataType.Numeric),
        new JdeField("EIUPMT", "EIUPMT", JdeDataType.Numeric),
        new JdeField("EIPID", "EIPID", JdeDataType.String, 20),
        new JdeField("EIMKEY", "EIMKEY", JdeDataType.String, 30),
        new JdeField("EIJVNNU1", "EIJVNNU1", JdeDataType.Numeric),
        new JdeField("EIJVNNU2", "EIJVNNU2", JdeDataType.Numeric),
        new JdeField("EIJVNNU3", "EIJVNNU3", JdeDataType.Numeric),
        new JdeField("EIJVNST1", "EIJVNST1", JdeDataType.String, 160),
        new JdeField("EIJVNST2", "EIJVNST2", JdeDataType.String, 160),
        new JdeField("EIJVNST3", "EIJVNST3", JdeDataType.String, 160),
        new JdeField("EIJVNCH1", "EIJVNCH1", JdeDataType.String, 2),
        new JdeField("EIJVNCH2", "EIJVNCH2", JdeDataType.String, 2),
        new JdeField("EIJVNCH3", "EIJVNCH3", JdeDataType.String, 2),
        new JdeField("EIJVNDT1", "EIJVNDT1", JdeDataType.Numeric),
        new JdeField("EIJVNDT2", "EIJVNDT2", JdeDataType.Numeric),
        new JdeField("EIJVNDT3", "EIJVNDT3", JdeDataType.Numeric),
        new JdeField("EIURATE01", "EIURATE01", JdeDataType.Numeric),
        new JdeField("EIURATE02", "EIURATE02", JdeDataType.Numeric),
        new JdeField("EIURATE03", "EIURATE03", JdeDataType.Numeric),
        new JdeField("EIURATE04", "EIURATE04", JdeDataType.Numeric),
        new JdeField("EIURATE05", "EIURATE05", JdeDataType.Numeric),
        new JdeField("EIURCDE01", "EIURCDE01", JdeDataType.String, 20),
        new JdeField("EIURCDE02", "EIURCDE02", JdeDataType.String, 20),
        new JdeField("EIURCDE03", "EIURCDE03", JdeDataType.String, 20),
        new JdeField("EIURCDE04", "EIURCDE04", JdeDataType.String, 20),
        new JdeField("EIURCDE05", "EIURCDE05", JdeDataType.String, 20),
        new JdeField("EIURDTE01", "EIURDTE01", JdeDataType.Numeric),
        new JdeField("EIURDTE02", "EIURDTE02", JdeDataType.Numeric),
        new JdeField("EIURDTE03", "EIURDTE03", JdeDataType.Numeric),
        new JdeField("EIURDTE04", "EIURDTE04", JdeDataType.Numeric),
        new JdeField("EIURDTE05", "EIURDTE05", JdeDataType.Numeric),
        new JdeField("EIURNUME01", "EIURNUME01", JdeDataType.Numeric),
        new JdeField("EIURNUME02", "EIURNUME02", JdeDataType.Numeric),
        new JdeField("EIURNUME03", "EIURNUME03", JdeDataType.Numeric),
        new JdeField("EIURNUME04", "EIURNUME04", JdeDataType.Numeric),
        new JdeField("EIURNUME05", "EIURNUME05", JdeDataType.Numeric),
        new JdeField("EIURRFE01", "EIURRFE01", JdeDataType.String, 30),
        new JdeField("EIURRFE02", "EIURRFE02", JdeDataType.String, 30),
        new JdeField("EIURRFE03", "EIURRFE03", JdeDataType.String, 30),
        new JdeField("EIURRFE04", "EIURRFE04", JdeDataType.String, 30),
        new JdeField("EIURRFE05", "EIURRFE05", JdeDataType.String, 30),
        new JdeField("EIURSTE01", "EIURSTE01", JdeDataType.String, 160),
        new JdeField("EIURSTE02", "EIURSTE02", JdeDataType.String, 160),
        new JdeField("EIURSTE03", "EIURSTE03", JdeDataType.String, 160),
        new JdeField("EIURSTE04", "EIURSTE04", JdeDataType.String, 160),
        new JdeField("EIURSTE05", "EIURSTE05", JdeDataType.String, 160)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F09J60_0", "Primary Key on EIJVEIX, EICALYEAR", new[] { "EIJVEIX", "EICALYEAR" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F09J60_2", "Index on EIJVEIX", new[] { "EIJVEIX" })
    };
}
