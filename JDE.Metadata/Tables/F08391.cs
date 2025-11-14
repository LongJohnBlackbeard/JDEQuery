using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F08391 - .
/// </summary>
public class F08391 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// B0PRG.
        /// </summary>
        public const string B0PRG = "B0PRG";

        /// <summary>
        /// B0XH01.
        /// </summary>
        public const string B0XH01 = "B0XH01";

        /// <summary>
        /// B0XH02.
        /// </summary>
        public const string B0XH02 = "B0XH02";

        /// <summary>
        /// B0XH03.
        /// </summary>
        public const string B0XH03 = "B0XH03";

        /// <summary>
        /// B0XH04.
        /// </summary>
        public const string B0XH04 = "B0XH04";

        /// <summary>
        /// B0XH05.
        /// </summary>
        public const string B0XH05 = "B0XH05";

        /// <summary>
        /// B0XDD1.
        /// </summary>
        public const string B0XDD1 = "B0XDD1";

        /// <summary>
        /// B0XDD2.
        /// </summary>
        public const string B0XDD2 = "B0XDD2";

        /// <summary>
        /// B0XDD3.
        /// </summary>
        public const string B0XDD3 = "B0XDD3";

        /// <summary>
        /// B0XDD4.
        /// </summary>
        public const string B0XDD4 = "B0XDD4";

        /// <summary>
        /// B0XDD5.
        /// </summary>
        public const string B0XDD5 = "B0XDD5";

        /// <summary>
        /// B0UDB1.
        /// </summary>
        public const string B0UDB1 = "B0UDB1";

        /// <summary>
        /// B0UDB2.
        /// </summary>
        public const string B0UDB2 = "B0UDB2";

        /// <summary>
        /// B0UTB1.
        /// </summary>
        public const string B0UTB1 = "B0UTB1";

        /// <summary>
        /// B0UTB2.
        /// </summary>
        public const string B0UTB2 = "B0UTB2";

        /// <summary>
        /// B0DL01.
        /// </summary>
        public const string B0DL01 = "B0DL01";

        /// <summary>
        /// B0DL02.
        /// </summary>
        public const string B0DL02 = "B0DL02";

        /// <summary>
        /// B0DL03.
        /// </summary>
        public const string B0DL03 = "B0DL03";

        /// <summary>
        /// B0DL04.
        /// </summary>
        public const string B0DL04 = "B0DL04";

        /// <summary>
        /// B0DL05.
        /// </summary>
        public const string B0DL05 = "B0DL05";

        /// <summary>
        /// B0DL06.
        /// </summary>
        public const string B0DL06 = "B0DL06";

        /// <summary>
        /// B0DL07.
        /// </summary>
        public const string B0DL07 = "B0DL07";

        /// <summary>
        /// B0DL08.
        /// </summary>
        public const string B0DL08 = "B0DL08";

        /// <summary>
        /// B0DL09.
        /// </summary>
        public const string B0DL09 = "B0DL09";

        /// <summary>
        /// B0DL10.
        /// </summary>
        public const string B0DL10 = "B0DL10";

        /// <summary>
        /// B0DL11.
        /// </summary>
        public const string B0DL11 = "B0DL11";

        /// <summary>
        /// B0DL12.
        /// </summary>
        public const string B0DL12 = "B0DL12";

        /// <summary>
        /// B0DL13.
        /// </summary>
        public const string B0DL13 = "B0DL13";
    }

    /// <inheritdoc />
    public override string TableName => "F08391";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("B0PRG", "B0PRG", JdeDataType.String, 20, true, true),
        new JdeField("B0XH01", "B0XH01", JdeDataType.Numeric),
        new JdeField("B0XH02", "B0XH02", JdeDataType.Numeric),
        new JdeField("B0XH03", "B0XH03", JdeDataType.Numeric),
        new JdeField("B0XH04", "B0XH04", JdeDataType.Numeric),
        new JdeField("B0XH05", "B0XH05", JdeDataType.Numeric),
        new JdeField("B0XDD1", "B0XDD1", JdeDataType.Numeric),
        new JdeField("B0XDD2", "B0XDD2", JdeDataType.Numeric),
        new JdeField("B0XDD3", "B0XDD3", JdeDataType.Numeric),
        new JdeField("B0XDD4", "B0XDD4", JdeDataType.Numeric),
        new JdeField("B0XDD5", "B0XDD5", JdeDataType.Numeric),
        new JdeField("B0UDB1", "B0UDB1", JdeDataType.Numeric),
        new JdeField("B0UDB2", "B0UDB2", JdeDataType.Numeric),
        new JdeField("B0UTB1", "B0UTB1", JdeDataType.String, 10),
        new JdeField("B0UTB2", "B0UTB2", JdeDataType.String, 10),
        new JdeField("B0DL01", "B0DL01", JdeDataType.String, 60),
        new JdeField("B0DL02", "B0DL02", JdeDataType.String, 60),
        new JdeField("B0DL03", "B0DL03", JdeDataType.String, 60),
        new JdeField("B0DL04", "B0DL04", JdeDataType.String, 60),
        new JdeField("B0DL05", "B0DL05", JdeDataType.String, 60),
        new JdeField("B0DL06", "B0DL06", JdeDataType.String, 60),
        new JdeField("B0DL07", "B0DL07", JdeDataType.String, 60),
        new JdeField("B0DL08", "B0DL08", JdeDataType.String, 60),
        new JdeField("B0DL09", "B0DL09", JdeDataType.String, 60),
        new JdeField("B0DL10", "B0DL10", JdeDataType.String, 60),
        new JdeField("B0DL11", "B0DL11", JdeDataType.String, 60),
        new JdeField("B0DL12", "B0DL12", JdeDataType.String, 60),
        new JdeField("B0DL13", "B0DL13", JdeDataType.String, 60)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F08391_0", "Primary Key on B0PRG", new[] { "B0PRG" }, isUnique: true, isPrimaryKey: true)
    };
}
