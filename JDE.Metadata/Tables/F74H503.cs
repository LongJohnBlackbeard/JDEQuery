using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F74H503 - .
/// </summary>
public class F74H503 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// VCUKID.
        /// </summary>
        public const string VCUKID = "VCUKID";

        /// <summary>
        /// VCH74VLRCD.
        /// </summary>
        public const string VCH74VLRCD = "VCH74VLRCD";

        /// <summary>
        /// VCH74INVST.
        /// </summary>
        public const string VCH74INVST = "VCH74INVST";

        /// <summary>
        /// VCH74MSSG.
        /// </summary>
        public const string VCH74MSSG = "VCH74MSSG";

        /// <summary>
        /// VCUSER.
        /// </summary>
        public const string VCUSER = "VCUSER";

        /// <summary>
        /// VCPID.
        /// </summary>
        public const string VCPID = "VCPID";

        /// <summary>
        /// VCJOBN.
        /// </summary>
        public const string VCJOBN = "VCJOBN";

        /// <summary>
        /// VCUPMJ.
        /// </summary>
        public const string VCUPMJ = "VCUPMJ";

        /// <summary>
        /// VCUPMT.
        /// </summary>
        public const string VCUPMT = "VCUPMT";

        /// <summary>
        /// VCH74FUTDT.
        /// </summary>
        public const string VCH74FUTDT = "VCH74FUTDT";

        /// <summary>
        /// VCH74FUTNM.
        /// </summary>
        public const string VCH74FUTNM = "VCH74FUTNM";

        /// <summary>
        /// VCFUT6.
        /// </summary>
        public const string VCFUT6 = "VCFUT6";

        /// <summary>
        /// VCX2.
        /// </summary>
        public const string VCX2 = "VCX2";

        /// <summary>
        /// VCH74FUTCH.
        /// </summary>
        public const string VCH74FUTCH = "VCH74FUTCH";
    }

    /// <inheritdoc />
    public override string TableName => "F74H503";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("VCUKID", "VCUKID", JdeDataType.Numeric, null, true, true),
        new JdeField("VCH74VLRCD", "VCH74VLRCD", JdeDataType.String, 100),
        new JdeField("VCH74INVST", "VCH74INVST", JdeDataType.String, 2),
        new JdeField("VCH74MSSG", "VCH74MSSG", JdeDataType.String, 2048),
        new JdeField("VCUSER", "VCUSER", JdeDataType.String, 20),
        new JdeField("VCPID", "VCPID", JdeDataType.String, 20),
        new JdeField("VCJOBN", "VCJOBN", JdeDataType.String, 20),
        new JdeField("VCUPMJ", "VCUPMJ", JdeDataType.Numeric),
        new JdeField("VCUPMT", "VCUPMT", JdeDataType.Numeric),
        new JdeField("VCH74FUTDT", "VCH74FUTDT", JdeDataType.Numeric),
        new JdeField("VCH74FUTNM", "VCH74FUTNM", JdeDataType.Numeric),
        new JdeField("VCFUT6", "VCFUT6", JdeDataType.String, 60),
        new JdeField("VCX2", "VCX2", JdeDataType.String, 2),
        new JdeField("VCH74FUTCH", "VCH74FUTCH", JdeDataType.String, 2)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F74H503_0", "Primary Key on VCUKID", new[] { "VCUKID" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F74H503_2", "Unique Index on VCH74VLRCD", new[] { "VCH74VLRCD" }, isUnique: true)
    };
}
