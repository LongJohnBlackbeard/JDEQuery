using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F75I301 - .
/// </summary>
public class F75I301 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// Q1YEXU.
        /// </summary>
        public const string Q1YEXU = "Q1YEXU";

        /// <summary>
        /// Q1YETT.
        /// </summary>
        public const string Q1YETT = "Q1YETT";

        /// <summary>
        /// Q1LNID.
        /// </summary>
        public const string Q1LNID = "Q1LNID";

        /// <summary>
        /// Q1LOCN.
        /// </summary>
        public const string Q1LOCN = "Q1LOCN";

        /// <summary>
        /// Q1DCTO.
        /// </summary>
        public const string Q1DCTO = "Q1DCTO";

        /// <summary>
        /// Q1DCT.
        /// </summary>
        public const string Q1DCT = "Q1DCT";

        /// <summary>
        /// Q1YN01.
        /// </summary>
        public const string Q1YN01 = "Q1YN01";

        /// <summary>
        /// Q1YN02.
        /// </summary>
        public const string Q1YN02 = "Q1YN02";

        /// <summary>
        /// Q1YN03.
        /// </summary>
        public const string Q1YN03 = "Q1YN03";

        /// <summary>
        /// Q1YN04.
        /// </summary>
        public const string Q1YN04 = "Q1YN04";

        /// <summary>
        /// Q1YN05.
        /// </summary>
        public const string Q1YN05 = "Q1YN05";

        /// <summary>
        /// Q1YN06.
        /// </summary>
        public const string Q1YN06 = "Q1YN06";

        /// <summary>
        /// Q1YN07.
        /// </summary>
        public const string Q1YN07 = "Q1YN07";

        /// <summary>
        /// Q1YN08.
        /// </summary>
        public const string Q1YN08 = "Q1YN08";

        /// <summary>
        /// Q1YN09.
        /// </summary>
        public const string Q1YN09 = "Q1YN09";

        /// <summary>
        /// Q1YN10.
        /// </summary>
        public const string Q1YN10 = "Q1YN10";

        /// <summary>
        /// Q1USER.
        /// </summary>
        public const string Q1USER = "Q1USER";

        /// <summary>
        /// Q1JOBN.
        /// </summary>
        public const string Q1JOBN = "Q1JOBN";

        /// <summary>
        /// Q1UPMJ.
        /// </summary>
        public const string Q1UPMJ = "Q1UPMJ";

        /// <summary>
        /// Q1TDAY.
        /// </summary>
        public const string Q1TDAY = "Q1TDAY";

        /// <summary>
        /// Q1PID.
        /// </summary>
        public const string Q1PID = "Q1PID";
    }

    /// <inheritdoc />
    public override string TableName => "F75I301";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("Q1YEXU", "Q1YEXU", JdeDataType.Numeric, null, true, true),
        new JdeField("Q1YETT", "Q1YETT", JdeDataType.String, 8, true, true),
        new JdeField("Q1LNID", "Q1LNID", JdeDataType.Numeric, null, true, true),
        new JdeField("Q1LOCN", "Q1LOCN", JdeDataType.String, 40),
        new JdeField("Q1DCTO", "Q1DCTO", JdeDataType.String, 4),
        new JdeField("Q1DCT", "Q1DCT", JdeDataType.String, 4),
        new JdeField("Q1YN01", "Q1YN01", JdeDataType.String, 2),
        new JdeField("Q1YN02", "Q1YN02", JdeDataType.String, 2),
        new JdeField("Q1YN03", "Q1YN03", JdeDataType.String, 2),
        new JdeField("Q1YN04", "Q1YN04", JdeDataType.String, 2),
        new JdeField("Q1YN05", "Q1YN05", JdeDataType.String, 2),
        new JdeField("Q1YN06", "Q1YN06", JdeDataType.String, 2),
        new JdeField("Q1YN07", "Q1YN07", JdeDataType.String, 2),
        new JdeField("Q1YN08", "Q1YN08", JdeDataType.String, 2),
        new JdeField("Q1YN09", "Q1YN09", JdeDataType.String, 2),
        new JdeField("Q1YN10", "Q1YN10", JdeDataType.String, 2),
        new JdeField("Q1USER", "Q1USER", JdeDataType.String, 20),
        new JdeField("Q1JOBN", "Q1JOBN", JdeDataType.String, 20),
        new JdeField("Q1UPMJ", "Q1UPMJ", JdeDataType.Numeric),
        new JdeField("Q1TDAY", "Q1TDAY", JdeDataType.Numeric),
        new JdeField("Q1PID", "Q1PID", JdeDataType.String, 20)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F75I301_0", "Primary Key on Q1YEXU, Q1YETT, Q1LNID", new[] { "Q1YEXU", "Q1YETT", "Q1LNID" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F75I301_4", "Index on Q1YETT, Q1DCTO, Q1DCT", new[] { "Q1YETT", "Q1DCTO", "Q1DCT" }),
        new JdeIndex("F75I301_5", "Unique Index on Q1YEXU, Q1DCTO, Q1DCT", new[] { "Q1YEXU", "Q1DCTO", "Q1DCT" }, isUnique: true),
        new JdeIndex("F75I301_7", "Index on Q1YEXU, Q1YETT, SYS_NC00022$", new[] { "Q1YEXU", "Q1YETT", "SYS_NC00022$" })
    };
}
