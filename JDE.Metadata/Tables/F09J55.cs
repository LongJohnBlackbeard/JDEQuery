using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F09J55 - .
/// </summary>
public class F09J55 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// OAJVOVN.
        /// </summary>
        public const string OAJVOVN = "OAJVOVN";

        /// <summary>
        /// OAJVOM.
        /// </summary>
        public const string OAJVOM = "OAJVOM";

        /// <summary>
        /// OAJVLNID.
        /// </summary>
        public const string OAJVLNID = "OAJVLNID";

        /// <summary>
        /// OASSLN.
        /// </summary>
        public const string OASSLN = "OASSLN";

        /// <summary>
        /// OAJVSLL.
        /// </summary>
        public const string OAJVSLL = "OAJVSLL";

        /// <summary>
        /// OAJVSUL.
        /// </summary>
        public const string OAJVSUL = "OAJVSUL";

        /// <summary>
        /// OAJVSP.
        /// </summary>
        public const string OAJVSP = "OAJVSP";

        /// <summary>
        /// OACRCD.
        /// </summary>
        public const string OACRCD = "OACRCD";

        /// <summary>
        /// OATORG.
        /// </summary>
        public const string OATORG = "OATORG";

        /// <summary>
        /// OAENTJ.
        /// </summary>
        public const string OAENTJ = "OAENTJ";

        /// <summary>
        /// OAUSER.
        /// </summary>
        public const string OAUSER = "OAUSER";

        /// <summary>
        /// OAUPMJ.
        /// </summary>
        public const string OAUPMJ = "OAUPMJ";

        /// <summary>
        /// OAUPMT.
        /// </summary>
        public const string OAUPMT = "OAUPMT";

        /// <summary>
        /// OAPID.
        /// </summary>
        public const string OAPID = "OAPID";

        /// <summary>
        /// OAMKEY.
        /// </summary>
        public const string OAMKEY = "OAMKEY";

        /// <summary>
        /// OAJVINU1.
        /// </summary>
        public const string OAJVINU1 = "OAJVINU1";

        /// <summary>
        /// OAJVINU2.
        /// </summary>
        public const string OAJVINU2 = "OAJVINU2";

        /// <summary>
        /// OAJVINU3.
        /// </summary>
        public const string OAJVINU3 = "OAJVINU3";

        /// <summary>
        /// OAJVIST1.
        /// </summary>
        public const string OAJVIST1 = "OAJVIST1";

        /// <summary>
        /// OAJVIST2.
        /// </summary>
        public const string OAJVIST2 = "OAJVIST2";

        /// <summary>
        /// OAJVIST3.
        /// </summary>
        public const string OAJVIST3 = "OAJVIST3";

        /// <summary>
        /// OAJVICH1.
        /// </summary>
        public const string OAJVICH1 = "OAJVICH1";

        /// <summary>
        /// OAJVICH2.
        /// </summary>
        public const string OAJVICH2 = "OAJVICH2";

        /// <summary>
        /// OAJVICH3.
        /// </summary>
        public const string OAJVICH3 = "OAJVICH3";

        /// <summary>
        /// OAJVIDT1.
        /// </summary>
        public const string OAJVIDT1 = "OAJVIDT1";

        /// <summary>
        /// OAJVIDT2.
        /// </summary>
        public const string OAJVIDT2 = "OAJVIDT2";

        /// <summary>
        /// OAJVIDT3.
        /// </summary>
        public const string OAJVIDT3 = "OAJVIDT3";

        /// <summary>
        /// OAURATSS01.
        /// </summary>
        public const string OAURATSS01 = "OAURATSS01";

        /// <summary>
        /// OAURATSS02.
        /// </summary>
        public const string OAURATSS02 = "OAURATSS02";

        /// <summary>
        /// OAURATSS03.
        /// </summary>
        public const string OAURATSS03 = "OAURATSS03";

        /// <summary>
        /// OAURATSS04.
        /// </summary>
        public const string OAURATSS04 = "OAURATSS04";

        /// <summary>
        /// OAURATSS05.
        /// </summary>
        public const string OAURATSS05 = "OAURATSS05";

        /// <summary>
        /// OAURCDSS01.
        /// </summary>
        public const string OAURCDSS01 = "OAURCDSS01";

        /// <summary>
        /// OAURCDSS02.
        /// </summary>
        public const string OAURCDSS02 = "OAURCDSS02";

        /// <summary>
        /// OAURCDSS03.
        /// </summary>
        public const string OAURCDSS03 = "OAURCDSS03";

        /// <summary>
        /// OAURCDSS04.
        /// </summary>
        public const string OAURCDSS04 = "OAURCDSS04";

        /// <summary>
        /// OAURCDSS05.
        /// </summary>
        public const string OAURCDSS05 = "OAURCDSS05";

        /// <summary>
        /// OAURDTSS01.
        /// </summary>
        public const string OAURDTSS01 = "OAURDTSS01";

        /// <summary>
        /// OAURDTSS02.
        /// </summary>
        public const string OAURDTSS02 = "OAURDTSS02";

        /// <summary>
        /// OAURDTSS03.
        /// </summary>
        public const string OAURDTSS03 = "OAURDTSS03";

        /// <summary>
        /// OAURDTSS04.
        /// </summary>
        public const string OAURDTSS04 = "OAURDTSS04";

        /// <summary>
        /// OAURDTSS05.
        /// </summary>
        public const string OAURDTSS05 = "OAURDTSS05";

        /// <summary>
        /// OAURNUSS01.
        /// </summary>
        public const string OAURNUSS01 = "OAURNUSS01";

        /// <summary>
        /// OAURNUSS02.
        /// </summary>
        public const string OAURNUSS02 = "OAURNUSS02";

        /// <summary>
        /// OAURNUSS03.
        /// </summary>
        public const string OAURNUSS03 = "OAURNUSS03";

        /// <summary>
        /// OAURNUSS04.
        /// </summary>
        public const string OAURNUSS04 = "OAURNUSS04";

        /// <summary>
        /// OAURNUSS05.
        /// </summary>
        public const string OAURNUSS05 = "OAURNUSS05";

        /// <summary>
        /// OAURRFSS01.
        /// </summary>
        public const string OAURRFSS01 = "OAURRFSS01";

        /// <summary>
        /// OAURRFSS02.
        /// </summary>
        public const string OAURRFSS02 = "OAURRFSS02";

        /// <summary>
        /// OAURRFSS03.
        /// </summary>
        public const string OAURRFSS03 = "OAURRFSS03";

        /// <summary>
        /// OAURRFSS04.
        /// </summary>
        public const string OAURRFSS04 = "OAURRFSS04";

        /// <summary>
        /// OAURRFSS05.
        /// </summary>
        public const string OAURRFSS05 = "OAURRFSS05";

        /// <summary>
        /// OAURSTSS01.
        /// </summary>
        public const string OAURSTSS01 = "OAURSTSS01";

        /// <summary>
        /// OAURSTSS02.
        /// </summary>
        public const string OAURSTSS02 = "OAURSTSS02";

        /// <summary>
        /// OAURSTSS03.
        /// </summary>
        public const string OAURSTSS03 = "OAURSTSS03";

        /// <summary>
        /// OAURSTSS04.
        /// </summary>
        public const string OAURSTSS04 = "OAURSTSS04";

        /// <summary>
        /// OAURSTSS05.
        /// </summary>
        public const string OAURSTSS05 = "OAURSTSS05";
    }

    /// <inheritdoc />
    public override string TableName => "F09J55";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("OAJVOVN", "OAJVOVN", JdeDataType.String, 40, true, true),
        new JdeField("OAJVOM", "OAJVOM", JdeDataType.String, 4, true, true),
        new JdeField("OAJVLNID", "OAJVLNID", JdeDataType.Numeric, null, true, true),
        new JdeField("OASSLN", "OASSLN", JdeDataType.Numeric, null, true, true),
        new JdeField("OAJVSLL", "OAJVSLL", JdeDataType.Numeric),
        new JdeField("OAJVSUL", "OAJVSUL", JdeDataType.Numeric),
        new JdeField("OAJVSP", "OAJVSP", JdeDataType.Numeric),
        new JdeField("OACRCD", "OACRCD", JdeDataType.String, 6),
        new JdeField("OATORG", "OATORG", JdeDataType.String, 20),
        new JdeField("OAENTJ", "OAENTJ", JdeDataType.Numeric),
        new JdeField("OAUSER", "OAUSER", JdeDataType.String, 20),
        new JdeField("OAUPMJ", "OAUPMJ", JdeDataType.Numeric),
        new JdeField("OAUPMT", "OAUPMT", JdeDataType.Numeric),
        new JdeField("OAPID", "OAPID", JdeDataType.String, 20),
        new JdeField("OAMKEY", "OAMKEY", JdeDataType.String, 30),
        new JdeField("OAJVINU1", "OAJVINU1", JdeDataType.Numeric),
        new JdeField("OAJVINU2", "OAJVINU2", JdeDataType.Numeric),
        new JdeField("OAJVINU3", "OAJVINU3", JdeDataType.Numeric),
        new JdeField("OAJVIST1", "OAJVIST1", JdeDataType.String, 160),
        new JdeField("OAJVIST2", "OAJVIST2", JdeDataType.String, 160),
        new JdeField("OAJVIST3", "OAJVIST3", JdeDataType.String, 160),
        new JdeField("OAJVICH1", "OAJVICH1", JdeDataType.String, 2),
        new JdeField("OAJVICH2", "OAJVICH2", JdeDataType.String, 2),
        new JdeField("OAJVICH3", "OAJVICH3", JdeDataType.String, 2),
        new JdeField("OAJVIDT1", "OAJVIDT1", JdeDataType.Numeric),
        new JdeField("OAJVIDT2", "OAJVIDT2", JdeDataType.Numeric),
        new JdeField("OAJVIDT3", "OAJVIDT3", JdeDataType.Numeric),
        new JdeField("OAURATSS01", "OAURATSS01", JdeDataType.Numeric),
        new JdeField("OAURATSS02", "OAURATSS02", JdeDataType.Numeric),
        new JdeField("OAURATSS03", "OAURATSS03", JdeDataType.Numeric),
        new JdeField("OAURATSS04", "OAURATSS04", JdeDataType.Numeric),
        new JdeField("OAURATSS05", "OAURATSS05", JdeDataType.Numeric),
        new JdeField("OAURCDSS01", "OAURCDSS01", JdeDataType.String, 4),
        new JdeField("OAURCDSS02", "OAURCDSS02", JdeDataType.String, 4),
        new JdeField("OAURCDSS03", "OAURCDSS03", JdeDataType.String, 4),
        new JdeField("OAURCDSS04", "OAURCDSS04", JdeDataType.String, 4),
        new JdeField("OAURCDSS05", "OAURCDSS05", JdeDataType.String, 4),
        new JdeField("OAURDTSS01", "OAURDTSS01", JdeDataType.Numeric),
        new JdeField("OAURDTSS02", "OAURDTSS02", JdeDataType.Numeric),
        new JdeField("OAURDTSS03", "OAURDTSS03", JdeDataType.Numeric),
        new JdeField("OAURDTSS04", "OAURDTSS04", JdeDataType.Numeric),
        new JdeField("OAURDTSS05", "OAURDTSS05", JdeDataType.Numeric),
        new JdeField("OAURNUSS01", "OAURNUSS01", JdeDataType.Numeric),
        new JdeField("OAURNUSS02", "OAURNUSS02", JdeDataType.Numeric),
        new JdeField("OAURNUSS03", "OAURNUSS03", JdeDataType.Numeric),
        new JdeField("OAURNUSS04", "OAURNUSS04", JdeDataType.Numeric),
        new JdeField("OAURNUSS05", "OAURNUSS05", JdeDataType.Numeric),
        new JdeField("OAURRFSS01", "OAURRFSS01", JdeDataType.String, 30),
        new JdeField("OAURRFSS02", "OAURRFSS02", JdeDataType.String, 30),
        new JdeField("OAURRFSS03", "OAURRFSS03", JdeDataType.String, 30),
        new JdeField("OAURRFSS04", "OAURRFSS04", JdeDataType.String, 30),
        new JdeField("OAURRFSS05", "OAURRFSS05", JdeDataType.String, 30),
        new JdeField("OAURSTSS01", "OAURSTSS01", JdeDataType.String, 160),
        new JdeField("OAURSTSS02", "OAURSTSS02", JdeDataType.String, 160),
        new JdeField("OAURSTSS03", "OAURSTSS03", JdeDataType.String, 160),
        new JdeField("OAURSTSS04", "OAURSTSS04", JdeDataType.String, 160),
        new JdeField("OAURSTSS05", "OAURSTSS05", JdeDataType.String, 160)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F09J55_0", "Primary Key on OAJVOVN, OAJVOM, OAJVLNID, OASSLN", new[] { "OAJVOVN", "OAJVOM", "OAJVLNID", "OASSLN" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F09J55_2", "Index on OAJVOVN, OAJVOM, OAJVLNID", new[] { "OAJVOVN", "OAJVOM", "OAJVLNID" })
    };
}
