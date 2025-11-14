using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F0126 - .
/// </summary>
public class F0126 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// A#AN8.
        /// </summary>
        public const string A_AN8 = "A#AN8";

        /// <summary>
        /// A#MT.
        /// </summary>
        public const string A_MT = "A#MT";

        /// <summary>
        /// A#YR.
        /// </summary>
        public const string A_YR = "A#YR";

        /// <summary>
        /// A#CTRY.
        /// </summary>
        public const string A_CTRY = "A#CTRY";

        /// <summary>
        /// A#TD01.
        /// </summary>
        public const string A_TD01 = "A#TD01";

        /// <summary>
        /// A#TD02.
        /// </summary>
        public const string A_TD02 = "A#TD02";

        /// <summary>
        /// A#TD03.
        /// </summary>
        public const string A_TD03 = "A#TD03";

        /// <summary>
        /// A#TD04.
        /// </summary>
        public const string A_TD04 = "A#TD04";

        /// <summary>
        /// A#TD05.
        /// </summary>
        public const string A_TD05 = "A#TD05";

        /// <summary>
        /// A#TD06.
        /// </summary>
        public const string A_TD06 = "A#TD06";

        /// <summary>
        /// A#TD07.
        /// </summary>
        public const string A_TD07 = "A#TD07";

        /// <summary>
        /// A#TD08.
        /// </summary>
        public const string A_TD08 = "A#TD08";

        /// <summary>
        /// A#TD09.
        /// </summary>
        public const string A_TD09 = "A#TD09";

        /// <summary>
        /// A#TD10.
        /// </summary>
        public const string A_TD10 = "A#TD10";

        /// <summary>
        /// A#TD11.
        /// </summary>
        public const string A_TD11 = "A#TD11";

        /// <summary>
        /// A#TD12.
        /// </summary>
        public const string A_TD12 = "A#TD12";

        /// <summary>
        /// A#TD13.
        /// </summary>
        public const string A_TD13 = "A#TD13";

        /// <summary>
        /// A#TD14.
        /// </summary>
        public const string A_TD14 = "A#TD14";

        /// <summary>
        /// A#TD15.
        /// </summary>
        public const string A_TD15 = "A#TD15";

        /// <summary>
        /// A#TD16.
        /// </summary>
        public const string A_TD16 = "A#TD16";

        /// <summary>
        /// A#TD17.
        /// </summary>
        public const string A_TD17 = "A#TD17";

        /// <summary>
        /// A#TD18.
        /// </summary>
        public const string A_TD18 = "A#TD18";

        /// <summary>
        /// A#TD19.
        /// </summary>
        public const string A_TD19 = "A#TD19";

        /// <summary>
        /// A#TD20.
        /// </summary>
        public const string A_TD20 = "A#TD20";

        /// <summary>
        /// A#TD21.
        /// </summary>
        public const string A_TD21 = "A#TD21";

        /// <summary>
        /// A#TD22.
        /// </summary>
        public const string A_TD22 = "A#TD22";

        /// <summary>
        /// A#TD23.
        /// </summary>
        public const string A_TD23 = "A#TD23";

        /// <summary>
        /// A#TD24.
        /// </summary>
        public const string A_TD24 = "A#TD24";

        /// <summary>
        /// A#TD25.
        /// </summary>
        public const string A_TD25 = "A#TD25";

        /// <summary>
        /// A#TD26.
        /// </summary>
        public const string A_TD26 = "A#TD26";

        /// <summary>
        /// A#TD27.
        /// </summary>
        public const string A_TD27 = "A#TD27";

        /// <summary>
        /// A#TD28.
        /// </summary>
        public const string A_TD28 = "A#TD28";

        /// <summary>
        /// A#TD29.
        /// </summary>
        public const string A_TD29 = "A#TD29";

        /// <summary>
        /// A#TD30.
        /// </summary>
        public const string A_TD30 = "A#TD30";

        /// <summary>
        /// A#TD31.
        /// </summary>
        public const string A_TD31 = "A#TD31";

        /// <summary>
        /// A#JOBN.
        /// </summary>
        public const string A_JOBN = "A#JOBN";

        /// <summary>
        /// A#PID.
        /// </summary>
        public const string A_PID = "A#PID";

        /// <summary>
        /// A#USER.
        /// </summary>
        public const string A_USER = "A#USER";

        /// <summary>
        /// A#UPMJ.
        /// </summary>
        public const string A_UPMJ = "A#UPMJ";

        /// <summary>
        /// A#UPMT.
        /// </summary>
        public const string A_UPMT = "A#UPMT";
    }

    /// <inheritdoc />
    public override string TableName => "F0126";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("A#AN8", "A#AN8", JdeDataType.Numeric, null, true, true),
        new JdeField("A#MT", "A#MT", JdeDataType.Numeric, null, true, true),
        new JdeField("A#YR", "A#YR", JdeDataType.Numeric, null, true, true),
        new JdeField("A#CTRY", "A#CTRY", JdeDataType.Numeric, null, true, true),
        new JdeField("A#TD01", "A#TD01", JdeDataType.String, 2),
        new JdeField("A#TD02", "A#TD02", JdeDataType.String, 2),
        new JdeField("A#TD03", "A#TD03", JdeDataType.String, 2),
        new JdeField("A#TD04", "A#TD04", JdeDataType.String, 2),
        new JdeField("A#TD05", "A#TD05", JdeDataType.String, 2),
        new JdeField("A#TD06", "A#TD06", JdeDataType.String, 2),
        new JdeField("A#TD07", "A#TD07", JdeDataType.String, 2),
        new JdeField("A#TD08", "A#TD08", JdeDataType.String, 2),
        new JdeField("A#TD09", "A#TD09", JdeDataType.String, 2),
        new JdeField("A#TD10", "A#TD10", JdeDataType.String, 2),
        new JdeField("A#TD11", "A#TD11", JdeDataType.String, 2),
        new JdeField("A#TD12", "A#TD12", JdeDataType.String, 2),
        new JdeField("A#TD13", "A#TD13", JdeDataType.String, 2),
        new JdeField("A#TD14", "A#TD14", JdeDataType.String, 2),
        new JdeField("A#TD15", "A#TD15", JdeDataType.String, 2),
        new JdeField("A#TD16", "A#TD16", JdeDataType.String, 2),
        new JdeField("A#TD17", "A#TD17", JdeDataType.String, 2),
        new JdeField("A#TD18", "A#TD18", JdeDataType.String, 2),
        new JdeField("A#TD19", "A#TD19", JdeDataType.String, 2),
        new JdeField("A#TD20", "A#TD20", JdeDataType.String, 2),
        new JdeField("A#TD21", "A#TD21", JdeDataType.String, 2),
        new JdeField("A#TD22", "A#TD22", JdeDataType.String, 2),
        new JdeField("A#TD23", "A#TD23", JdeDataType.String, 2),
        new JdeField("A#TD24", "A#TD24", JdeDataType.String, 2),
        new JdeField("A#TD25", "A#TD25", JdeDataType.String, 2),
        new JdeField("A#TD26", "A#TD26", JdeDataType.String, 2),
        new JdeField("A#TD27", "A#TD27", JdeDataType.String, 2),
        new JdeField("A#TD28", "A#TD28", JdeDataType.String, 2),
        new JdeField("A#TD29", "A#TD29", JdeDataType.String, 2),
        new JdeField("A#TD30", "A#TD30", JdeDataType.String, 2),
        new JdeField("A#TD31", "A#TD31", JdeDataType.String, 2),
        new JdeField("A#JOBN", "A#JOBN", JdeDataType.String, 20),
        new JdeField("A#PID", "A#PID", JdeDataType.String, 20),
        new JdeField("A#USER", "A#USER", JdeDataType.String, 20),
        new JdeField("A#UPMJ", "A#UPMJ", JdeDataType.Numeric),
        new JdeField("A#UPMT", "A#UPMT", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F0126_0", "Primary Key on A#AN8, A#MT, A#YR, A#CTRY", new[] { "A#AN8", "A#MT", "A#YR", "A#CTRY" }, isUnique: true, isPrimaryKey: true)
    };
}
