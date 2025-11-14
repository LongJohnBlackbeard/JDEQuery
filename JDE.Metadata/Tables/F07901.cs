using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F07901 - .
/// </summary>
public class F07901 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// Y5DEDM.
        /// </summary>
        public const string Y5DEDM = "Y5DEDM";

        /// <summary>
        /// Y5PRUM.
        /// </summary>
        public const string Y5PRUM = "Y5PRUM";

        /// <summary>
        /// Y5LNID.
        /// </summary>
        public const string Y5LNID = "Y5LNID";

        /// <summary>
        /// Y5NMER.
        /// </summary>
        public const string Y5NMER = "Y5NMER";

        /// <summary>
        /// Y5BASS.
        /// </summary>
        public const string Y5BASS = "Y5BASS";

        /// <summary>
        /// Y5VN01.
        /// </summary>
        public const string Y5VN01 = "Y5VN01";

        /// <summary>
        /// Y5VN02.
        /// </summary>
        public const string Y5VN02 = "Y5VN02";

        /// <summary>
        /// Y5VN03.
        /// </summary>
        public const string Y5VN03 = "Y5VN03";

        /// <summary>
        /// Y5VN04.
        /// </summary>
        public const string Y5VN04 = "Y5VN04";

        /// <summary>
        /// Y5VN05.
        /// </summary>
        public const string Y5VN05 = "Y5VN05";

        /// <summary>
        /// Y5VN06.
        /// </summary>
        public const string Y5VN06 = "Y5VN06";

        /// <summary>
        /// Y5VN07.
        /// </summary>
        public const string Y5VN07 = "Y5VN07";

        /// <summary>
        /// Y5VN08.
        /// </summary>
        public const string Y5VN08 = "Y5VN08";

        /// <summary>
        /// Y5VN09.
        /// </summary>
        public const string Y5VN09 = "Y5VN09";

        /// <summary>
        /// Y5VN10.
        /// </summary>
        public const string Y5VN10 = "Y5VN10";

        /// <summary>
        /// Y5VN11.
        /// </summary>
        public const string Y5VN11 = "Y5VN11";

        /// <summary>
        /// Y5VN12.
        /// </summary>
        public const string Y5VN12 = "Y5VN12";

        /// <summary>
        /// Y5VN13.
        /// </summary>
        public const string Y5VN13 = "Y5VN13";

        /// <summary>
        /// Y5VN14.
        /// </summary>
        public const string Y5VN14 = "Y5VN14";

        /// <summary>
        /// Y5VN15.
        /// </summary>
        public const string Y5VN15 = "Y5VN15";

        /// <summary>
        /// Y5VN16.
        /// </summary>
        public const string Y5VN16 = "Y5VN16";

        /// <summary>
        /// Y5VN17.
        /// </summary>
        public const string Y5VN17 = "Y5VN17";

        /// <summary>
        /// Y5VN18.
        /// </summary>
        public const string Y5VN18 = "Y5VN18";

        /// <summary>
        /// Y5VN19.
        /// </summary>
        public const string Y5VN19 = "Y5VN19";

        /// <summary>
        /// Y5VN20.
        /// </summary>
        public const string Y5VN20 = "Y5VN20";

        /// <summary>
        /// Y5RE01.
        /// </summary>
        public const string Y5RE01 = "Y5RE01";

        /// <summary>
        /// Y5RE02.
        /// </summary>
        public const string Y5RE02 = "Y5RE02";

        /// <summary>
        /// Y5RE03.
        /// </summary>
        public const string Y5RE03 = "Y5RE03";

        /// <summary>
        /// Y5RE04.
        /// </summary>
        public const string Y5RE04 = "Y5RE04";

        /// <summary>
        /// Y5RE05.
        /// </summary>
        public const string Y5RE05 = "Y5RE05";

        /// <summary>
        /// Y5RE06.
        /// </summary>
        public const string Y5RE06 = "Y5RE06";

        /// <summary>
        /// Y5RE07.
        /// </summary>
        public const string Y5RE07 = "Y5RE07";

        /// <summary>
        /// Y5RE08.
        /// </summary>
        public const string Y5RE08 = "Y5RE08";

        /// <summary>
        /// Y5RE09.
        /// </summary>
        public const string Y5RE09 = "Y5RE09";

        /// <summary>
        /// Y5RE10.
        /// </summary>
        public const string Y5RE10 = "Y5RE10";

        /// <summary>
        /// Y5RE11.
        /// </summary>
        public const string Y5RE11 = "Y5RE11";

        /// <summary>
        /// Y5RE12.
        /// </summary>
        public const string Y5RE12 = "Y5RE12";

        /// <summary>
        /// Y5RE13.
        /// </summary>
        public const string Y5RE13 = "Y5RE13";

        /// <summary>
        /// Y5RE14.
        /// </summary>
        public const string Y5RE14 = "Y5RE14";

        /// <summary>
        /// Y5RE15.
        /// </summary>
        public const string Y5RE15 = "Y5RE15";

        /// <summary>
        /// Y5RE16.
        /// </summary>
        public const string Y5RE16 = "Y5RE16";

        /// <summary>
        /// Y5RE17.
        /// </summary>
        public const string Y5RE17 = "Y5RE17";

        /// <summary>
        /// Y5RE18.
        /// </summary>
        public const string Y5RE18 = "Y5RE18";

        /// <summary>
        /// Y5RE19.
        /// </summary>
        public const string Y5RE19 = "Y5RE19";

        /// <summary>
        /// Y5RE20.
        /// </summary>
        public const string Y5RE20 = "Y5RE20";

        /// <summary>
        /// Y5PID.
        /// </summary>
        public const string Y5PID = "Y5PID";

        /// <summary>
        /// Y5USER.
        /// </summary>
        public const string Y5USER = "Y5USER";

        /// <summary>
        /// Y5JOBN.
        /// </summary>
        public const string Y5JOBN = "Y5JOBN";

        /// <summary>
        /// Y5DTSP.
        /// </summary>
        public const string Y5DTSP = "Y5DTSP";
    }

    /// <inheritdoc />
    public override string TableName => "F07901";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("Y5DEDM", "Y5DEDM", JdeDataType.String, 2, true, true),
        new JdeField("Y5PRUM", "Y5PRUM", JdeDataType.String, 4, true, true),
        new JdeField("Y5LNID", "Y5LNID", JdeDataType.Numeric, null, true, true),
        new JdeField("Y5NMER", "Y5NMER", JdeDataType.String, 64),
        new JdeField("Y5BASS", "Y5BASS", JdeDataType.String, 2),
        new JdeField("Y5VN01", "Y5VN01", JdeDataType.String, 20),
        new JdeField("Y5VN02", "Y5VN02", JdeDataType.String, 20),
        new JdeField("Y5VN03", "Y5VN03", JdeDataType.String, 20),
        new JdeField("Y5VN04", "Y5VN04", JdeDataType.String, 20),
        new JdeField("Y5VN05", "Y5VN05", JdeDataType.String, 20),
        new JdeField("Y5VN06", "Y5VN06", JdeDataType.String, 20),
        new JdeField("Y5VN07", "Y5VN07", JdeDataType.String, 20),
        new JdeField("Y5VN08", "Y5VN08", JdeDataType.String, 20),
        new JdeField("Y5VN09", "Y5VN09", JdeDataType.String, 20),
        new JdeField("Y5VN10", "Y5VN10", JdeDataType.String, 20),
        new JdeField("Y5VN11", "Y5VN11", JdeDataType.String, 20),
        new JdeField("Y5VN12", "Y5VN12", JdeDataType.String, 20),
        new JdeField("Y5VN13", "Y5VN13", JdeDataType.String, 20),
        new JdeField("Y5VN14", "Y5VN14", JdeDataType.String, 20),
        new JdeField("Y5VN15", "Y5VN15", JdeDataType.String, 20),
        new JdeField("Y5VN16", "Y5VN16", JdeDataType.String, 20),
        new JdeField("Y5VN17", "Y5VN17", JdeDataType.String, 20),
        new JdeField("Y5VN18", "Y5VN18", JdeDataType.String, 20),
        new JdeField("Y5VN19", "Y5VN19", JdeDataType.String, 20),
        new JdeField("Y5VN20", "Y5VN20", JdeDataType.String, 20),
        new JdeField("Y5RE01", "Y5RE01", JdeDataType.String, 20),
        new JdeField("Y5RE02", "Y5RE02", JdeDataType.String, 20),
        new JdeField("Y5RE03", "Y5RE03", JdeDataType.String, 20),
        new JdeField("Y5RE04", "Y5RE04", JdeDataType.String, 20),
        new JdeField("Y5RE05", "Y5RE05", JdeDataType.String, 20),
        new JdeField("Y5RE06", "Y5RE06", JdeDataType.String, 20),
        new JdeField("Y5RE07", "Y5RE07", JdeDataType.String, 20),
        new JdeField("Y5RE08", "Y5RE08", JdeDataType.String, 20),
        new JdeField("Y5RE09", "Y5RE09", JdeDataType.String, 20),
        new JdeField("Y5RE10", "Y5RE10", JdeDataType.String, 20),
        new JdeField("Y5RE11", "Y5RE11", JdeDataType.String, 20),
        new JdeField("Y5RE12", "Y5RE12", JdeDataType.String, 20),
        new JdeField("Y5RE13", "Y5RE13", JdeDataType.String, 20),
        new JdeField("Y5RE14", "Y5RE14", JdeDataType.String, 20),
        new JdeField("Y5RE15", "Y5RE15", JdeDataType.String, 20),
        new JdeField("Y5RE16", "Y5RE16", JdeDataType.String, 20),
        new JdeField("Y5RE17", "Y5RE17", JdeDataType.String, 20),
        new JdeField("Y5RE18", "Y5RE18", JdeDataType.String, 20),
        new JdeField("Y5RE19", "Y5RE19", JdeDataType.String, 20),
        new JdeField("Y5RE20", "Y5RE20", JdeDataType.String, 20),
        new JdeField("Y5PID", "Y5PID", JdeDataType.String, 20),
        new JdeField("Y5USER", "Y5USER", JdeDataType.String, 20),
        new JdeField("Y5JOBN", "Y5JOBN", JdeDataType.String, 20),
        new JdeField("Y5DTSP", "Y5DTSP", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F07901_0", "Primary Key on Y5DEDM, Y5PRUM, Y5LNID", new[] { "Y5DEDM", "Y5PRUM", "Y5LNID" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F07901_2", "Index on Y5DEDM, Y5PRUM, Y5LNID, Y5BASS", new[] { "Y5DEDM", "Y5PRUM", "Y5LNID", "Y5BASS" })
    };
}
