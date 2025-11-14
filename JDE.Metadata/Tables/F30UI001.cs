using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F30UI001 - .
/// </summary>
public class F30UI001 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// WFCTID.
        /// </summary>
        public const string WFCTID = "WFCTID";

        /// <summary>
        /// WFJOBS.
        /// </summary>
        public const string WFJOBS = "WFJOBS";

        /// <summary>
        /// WFLNID.
        /// </summary>
        public const string WFLNID = "WFLNID";

        /// <summary>
        /// WFLO01.
        /// </summary>
        public const string WFLO01 = "WFLO01";

        /// <summary>
        /// WFLO02.
        /// </summary>
        public const string WFLO02 = "WFLO02";

        /// <summary>
        /// WFLO03.
        /// </summary>
        public const string WFLO03 = "WFLO03";

        /// <summary>
        /// WFLO04.
        /// </summary>
        public const string WFLO04 = "WFLO04";

        /// <summary>
        /// WFLO05.
        /// </summary>
        public const string WFLO05 = "WFLO05";

        /// <summary>
        /// WFLO06.
        /// </summary>
        public const string WFLO06 = "WFLO06";

        /// <summary>
        /// WFLO07.
        /// </summary>
        public const string WFLO07 = "WFLO07";

        /// <summary>
        /// WFLO08.
        /// </summary>
        public const string WFLO08 = "WFLO08";

        /// <summary>
        /// WFLO09.
        /// </summary>
        public const string WFLO09 = "WFLO09";

        /// <summary>
        /// WFLO10.
        /// </summary>
        public const string WFLO10 = "WFLO10";

        /// <summary>
        /// WFLO11.
        /// </summary>
        public const string WFLO11 = "WFLO11";

        /// <summary>
        /// WFLO12.
        /// </summary>
        public const string WFLO12 = "WFLO12";

        /// <summary>
        /// WFLO13.
        /// </summary>
        public const string WFLO13 = "WFLO13";

        /// <summary>
        /// WFLO14.
        /// </summary>
        public const string WFLO14 = "WFLO14";

        /// <summary>
        /// WFLO15.
        /// </summary>
        public const string WFLO15 = "WFLO15";

        /// <summary>
        /// WFLO16.
        /// </summary>
        public const string WFLO16 = "WFLO16";

        /// <summary>
        /// WFLO17.
        /// </summary>
        public const string WFLO17 = "WFLO17";

        /// <summary>
        /// WFLO18.
        /// </summary>
        public const string WFLO18 = "WFLO18";

        /// <summary>
        /// WFLO19.
        /// </summary>
        public const string WFLO19 = "WFLO19";

        /// <summary>
        /// WFBLOC.
        /// </summary>
        public const string WFBLOC = "WFBLOC";

        /// <summary>
        /// WFUK01.
        /// </summary>
        public const string WFUK01 = "WFUK01";

        /// <summary>
        /// WFUK02.
        /// </summary>
        public const string WFUK02 = "WFUK02";

        /// <summary>
        /// WFUK03.
        /// </summary>
        public const string WFUK03 = "WFUK03";

        /// <summary>
        /// WFUK04.
        /// </summary>
        public const string WFUK04 = "WFUK04";

        /// <summary>
        /// WFUK05.
        /// </summary>
        public const string WFUK05 = "WFUK05";

        /// <summary>
        /// WFUK06.
        /// </summary>
        public const string WFUK06 = "WFUK06";

        /// <summary>
        /// WFUK07.
        /// </summary>
        public const string WFUK07 = "WFUK07";

        /// <summary>
        /// WFUK08.
        /// </summary>
        public const string WFUK08 = "WFUK08";

        /// <summary>
        /// WFUK09.
        /// </summary>
        public const string WFUK09 = "WFUK09";

        /// <summary>
        /// WFUKID.
        /// </summary>
        public const string WFUKID = "WFUKID";
    }

    /// <inheritdoc />
    public override string TableName => "F30UI001";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("WFCTID", "WFCTID", JdeDataType.String, 30, true, true),
        new JdeField("WFJOBS", "WFJOBS", JdeDataType.Numeric, null, true, true),
        new JdeField("WFLNID", "WFLNID", JdeDataType.Numeric, null, true, true),
        new JdeField("WFLO01", "WFLO01", JdeDataType.String, 10),
        new JdeField("WFLO02", "WFLO02", JdeDataType.String, 10),
        new JdeField("WFLO03", "WFLO03", JdeDataType.String, 10),
        new JdeField("WFLO04", "WFLO04", JdeDataType.String, 10),
        new JdeField("WFLO05", "WFLO05", JdeDataType.String, 10),
        new JdeField("WFLO06", "WFLO06", JdeDataType.String, 10),
        new JdeField("WFLO07", "WFLO07", JdeDataType.String, 10),
        new JdeField("WFLO08", "WFLO08", JdeDataType.String, 10),
        new JdeField("WFLO09", "WFLO09", JdeDataType.String, 10),
        new JdeField("WFLO10", "WFLO10", JdeDataType.String, 10),
        new JdeField("WFLO11", "WFLO11", JdeDataType.String, 10),
        new JdeField("WFLO12", "WFLO12", JdeDataType.String, 10),
        new JdeField("WFLO13", "WFLO13", JdeDataType.String, 10),
        new JdeField("WFLO14", "WFLO14", JdeDataType.String, 10),
        new JdeField("WFLO15", "WFLO15", JdeDataType.String, 10),
        new JdeField("WFLO16", "WFLO16", JdeDataType.String, 10),
        new JdeField("WFLO17", "WFLO17", JdeDataType.String, 10),
        new JdeField("WFLO18", "WFLO18", JdeDataType.String, 10),
        new JdeField("WFLO19", "WFLO19", JdeDataType.String, 10),
        new JdeField("WFBLOC", "WFBLOC", JdeDataType.String, 10),
        new JdeField("WFUK01", "WFUK01", JdeDataType.Numeric),
        new JdeField("WFUK02", "WFUK02", JdeDataType.Numeric),
        new JdeField("WFUK03", "WFUK03", JdeDataType.Numeric),
        new JdeField("WFUK04", "WFUK04", JdeDataType.Numeric),
        new JdeField("WFUK05", "WFUK05", JdeDataType.Numeric),
        new JdeField("WFUK06", "WFUK06", JdeDataType.Numeric),
        new JdeField("WFUK07", "WFUK07", JdeDataType.Numeric),
        new JdeField("WFUK08", "WFUK08", JdeDataType.Numeric),
        new JdeField("WFUK09", "WFUK09", JdeDataType.Numeric),
        new JdeField("WFUKID", "WFUKID", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F30UI001_0", "Primary Key on WFCTID, WFJOBS, WFLNID", new[] { "WFCTID", "WFJOBS", "WFLNID" }, isUnique: true, isPrimaryKey: true)
    };
}
