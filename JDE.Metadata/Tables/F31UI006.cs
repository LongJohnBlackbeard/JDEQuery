using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F31UI006 - .
/// </summary>
public class F31UI006 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// LSCTID.
        /// </summary>
        public const string LSCTID = "LSCTID";

        /// <summary>
        /// LSJOBS.
        /// </summary>
        public const string LSJOBS = "LSJOBS";

        /// <summary>
        /// LSMMCU.
        /// </summary>
        public const string LSMMCU = "LSMMCU";

        /// <summary>
        /// LSLINE.
        /// </summary>
        public const string LSLINE = "LSLINE";

        /// <summary>
        /// LSDOCO.
        /// </summary>
        public const string LSDOCO = "LSDOCO";

        /// <summary>
        /// LSDCTO.
        /// </summary>
        public const string LSDCTO = "LSDCTO";

        /// <summary>
        /// LSSHFT.
        /// </summary>
        public const string LSSHFT = "LSSHFT";

        /// <summary>
        /// LSSESD.
        /// </summary>
        public const string LSSESD = "LSSESD";

        /// <summary>
        /// LSLITM.
        /// </summary>
        public const string LSLITM = "LSLITM";

        /// <summary>
        /// LSHQ01.
        /// </summary>
        public const string LSHQ01 = "LSHQ01";

        /// <summary>
        /// LSHQ02.
        /// </summary>
        public const string LSHQ02 = "LSHQ02";

        /// <summary>
        /// LSHQ03.
        /// </summary>
        public const string LSHQ03 = "LSHQ03";

        /// <summary>
        /// LSHQ04.
        /// </summary>
        public const string LSHQ04 = "LSHQ04";

        /// <summary>
        /// LSHQ05.
        /// </summary>
        public const string LSHQ05 = "LSHQ05";

        /// <summary>
        /// LSUOM.
        /// </summary>
        public const string LSUOM = "LSUOM";

        /// <summary>
        /// LSCRU1.
        /// </summary>
        public const string LSCRU1 = "LSCRU1";

        /// <summary>
        /// LSCRU2.
        /// </summary>
        public const string LSCRU2 = "LSCRU2";

        /// <summary>
        /// LSCRU3.
        /// </summary>
        public const string LSCRU3 = "LSCRU3";

        /// <summary>
        /// LSCRU4.
        /// </summary>
        public const string LSCRU4 = "LSCRU4";

        /// <summary>
        /// LSCRU5.
        /// </summary>
        public const string LSCRU5 = "LSCRU5";

        /// <summary>
        /// LSEV01.
        /// </summary>
        public const string LSEV01 = "LSEV01";

        /// <summary>
        /// LSMERL.
        /// </summary>
        public const string LSMERL = "LSMERL";

        /// <summary>
        /// LSUORG.
        /// </summary>
        public const string LSUORG = "LSUORG";

        /// <summary>
        /// LSSCQT.
        /// </summary>
        public const string LSSCQT = "LSSCQT";

        /// <summary>
        /// LSOHQ1.
        /// </summary>
        public const string LSOHQ1 = "LSOHQ1";

        /// <summary>
        /// LSOHQ2.
        /// </summary>
        public const string LSOHQ2 = "LSOHQ2";

        /// <summary>
        /// LSOHQ3.
        /// </summary>
        public const string LSOHQ3 = "LSOHQ3";

        /// <summary>
        /// LSOHQ4.
        /// </summary>
        public const string LSOHQ4 = "LSOHQ4";

        /// <summary>
        /// LSOHQ5.
        /// </summary>
        public const string LSOHQ5 = "LSOHQ5";

        /// <summary>
        /// LSRUC.
        /// </summary>
        public const string LSRUC = "LSRUC";

        /// <summary>
        /// LSSTRT.
        /// </summary>
        public const string LSSTRT = "LSSTRT";

        /// <summary>
        /// LSDRQJ.
        /// </summary>
        public const string LSDRQJ = "LSDRQJ";

        /// <summary>
        /// LSSRST.
        /// </summary>
        public const string LSSRST = "LSSRST";

        /// <summary>
        /// LSITM.
        /// </summary>
        public const string LSITM = "LSITM";

        /// <summary>
        /// LSMWDH.
        /// </summary>
        public const string LSMWDH = "LSMWDH";

        /// <summary>
        /// LSEV02.
        /// </summary>
        public const string LSEV02 = "LSEV02";

        /// <summary>
        /// LSRORN.
        /// </summary>
        public const string LSRORN = "LSRORN";

        /// <summary>
        /// LSRCTO.
        /// </summary>
        public const string LSRCTO = "LSRCTO";

        /// <summary>
        /// LSEV11.
        /// </summary>
        public const string LSEV11 = "LSEV11";

        /// <summary>
        /// LSEV12.
        /// </summary>
        public const string LSEV12 = "LSEV12";

        /// <summary>
        /// LSEV13.
        /// </summary>
        public const string LSEV13 = "LSEV13";

        /// <summary>
        /// LSEV14.
        /// </summary>
        public const string LSEV14 = "LSEV14";

        /// <summary>
        /// LSEV15.
        /// </summary>
        public const string LSEV15 = "LSEV15";

        /// <summary>
        /// LSUKID.
        /// </summary>
        public const string LSUKID = "LSUKID";
    }

    /// <inheritdoc />
    public override string TableName => "F31UI006";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("LSCTID", "LSCTID", JdeDataType.String, 30, true, true),
        new JdeField("LSJOBS", "LSJOBS", JdeDataType.Numeric, null, true, true),
        new JdeField("LSMMCU", "LSMMCU", JdeDataType.String, 24),
        new JdeField("LSLINE", "LSLINE", JdeDataType.String, 24),
        new JdeField("LSDOCO", "LSDOCO", JdeDataType.Numeric, null, true, true),
        new JdeField("LSDCTO", "LSDCTO", JdeDataType.String, 4),
        new JdeField("LSSHFT", "LSSHFT", JdeDataType.String, 2),
        new JdeField("LSSESD", "LSSESD", JdeDataType.Numeric),
        new JdeField("LSLITM", "LSLITM", JdeDataType.String, 50),
        new JdeField("LSHQ01", "LSHQ01", JdeDataType.Numeric),
        new JdeField("LSHQ02", "LSHQ02", JdeDataType.Numeric),
        new JdeField("LSHQ03", "LSHQ03", JdeDataType.Numeric),
        new JdeField("LSHQ04", "LSHQ04", JdeDataType.Numeric),
        new JdeField("LSHQ05", "LSHQ05", JdeDataType.Numeric),
        new JdeField("LSUOM", "LSUOM", JdeDataType.String, 4),
        new JdeField("LSCRU1", "LSCRU1", JdeDataType.Numeric),
        new JdeField("LSCRU2", "LSCRU2", JdeDataType.Numeric),
        new JdeField("LSCRU3", "LSCRU3", JdeDataType.Numeric),
        new JdeField("LSCRU4", "LSCRU4", JdeDataType.Numeric),
        new JdeField("LSCRU5", "LSCRU5", JdeDataType.Numeric),
        new JdeField("LSEV01", "LSEV01", JdeDataType.String, 2),
        new JdeField("LSMERL", "LSMERL", JdeDataType.String, 6),
        new JdeField("LSUORG", "LSUORG", JdeDataType.Numeric),
        new JdeField("LSSCQT", "LSSCQT", JdeDataType.Numeric),
        new JdeField("LSOHQ1", "LSOHQ1", JdeDataType.Numeric),
        new JdeField("LSOHQ2", "LSOHQ2", JdeDataType.Numeric),
        new JdeField("LSOHQ3", "LSOHQ3", JdeDataType.Numeric),
        new JdeField("LSOHQ4", "LSOHQ4", JdeDataType.Numeric),
        new JdeField("LSOHQ5", "LSOHQ5", JdeDataType.Numeric),
        new JdeField("LSRUC", "LSRUC", JdeDataType.Numeric),
        new JdeField("LSSTRT", "LSSTRT", JdeDataType.Numeric),
        new JdeField("LSDRQJ", "LSDRQJ", JdeDataType.Numeric),
        new JdeField("LSSRST", "LSSRST", JdeDataType.String, 4),
        new JdeField("LSITM", "LSITM", JdeDataType.Numeric),
        new JdeField("LSMWDH", "LSMWDH", JdeDataType.String, 2),
        new JdeField("LSEV02", "LSEV02", JdeDataType.String, 2),
        new JdeField("LSRORN", "LSRORN", JdeDataType.String, 16),
        new JdeField("LSRCTO", "LSRCTO", JdeDataType.String, 4),
        new JdeField("LSEV11", "LSEV11", JdeDataType.String, 2),
        new JdeField("LSEV12", "LSEV12", JdeDataType.String, 2),
        new JdeField("LSEV13", "LSEV13", JdeDataType.String, 2),
        new JdeField("LSEV14", "LSEV14", JdeDataType.String, 2),
        new JdeField("LSEV15", "LSEV15", JdeDataType.String, 2),
        new JdeField("LSUKID", "LSUKID", JdeDataType.Numeric, null, true, true)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F31UI006_0", "Primary Key on LSCTID, LSJOBS, LSUKID, LSDOCO", new[] { "LSCTID", "LSJOBS", "LSUKID", "LSDOCO" }, isUnique: true, isPrimaryKey: true)
    };
}
