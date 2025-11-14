using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F1550 - .
/// </summary>
public class F1550 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// NVINDX.
        /// </summary>
        public const string NVINDX = "NVINDX";

        /// <summary>
        /// NVCTRY.
        /// </summary>
        public const string NVCTRY = "NVCTRY";

        /// <summary>
        /// NVYR.
        /// </summary>
        public const string NVYR = "NVYR";

        /// <summary>
        /// NVDL01.
        /// </summary>
        public const string NVDL01 = "NVDL01";

        /// <summary>
        /// NVIX01.
        /// </summary>
        public const string NVIX01 = "NVIX01";

        /// <summary>
        /// NVIX02.
        /// </summary>
        public const string NVIX02 = "NVIX02";

        /// <summary>
        /// NVIX03.
        /// </summary>
        public const string NVIX03 = "NVIX03";

        /// <summary>
        /// NVIX04.
        /// </summary>
        public const string NVIX04 = "NVIX04";

        /// <summary>
        /// NVIX05.
        /// </summary>
        public const string NVIX05 = "NVIX05";

        /// <summary>
        /// NVIX06.
        /// </summary>
        public const string NVIX06 = "NVIX06";

        /// <summary>
        /// NVIX07.
        /// </summary>
        public const string NVIX07 = "NVIX07";

        /// <summary>
        /// NVIX08.
        /// </summary>
        public const string NVIX08 = "NVIX08";

        /// <summary>
        /// NVIX09.
        /// </summary>
        public const string NVIX09 = "NVIX09";

        /// <summary>
        /// NVIX10.
        /// </summary>
        public const string NVIX10 = "NVIX10";

        /// <summary>
        /// NVIX11.
        /// </summary>
        public const string NVIX11 = "NVIX11";

        /// <summary>
        /// NVIX12.
        /// </summary>
        public const string NVIX12 = "NVIX12";

        /// <summary>
        /// NVUSER.
        /// </summary>
        public const string NVUSER = "NVUSER";

        /// <summary>
        /// NVUPMJ.
        /// </summary>
        public const string NVUPMJ = "NVUPMJ";

        /// <summary>
        /// NVPID.
        /// </summary>
        public const string NVPID = "NVPID";

        /// <summary>
        /// NVJOBN.
        /// </summary>
        public const string NVJOBN = "NVJOBN";

        /// <summary>
        /// NVPJCP.
        /// </summary>
        public const string NVPJCP = "NVPJCP";

        /// <summary>
        /// NVUPMT.
        /// </summary>
        public const string NVUPMT = "NVUPMT";
    }

    /// <inheritdoc />
    public override string TableName => "F1550";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("NVINDX", "NVINDX", JdeDataType.String, 10, true, true),
        new JdeField("NVCTRY", "NVCTRY", JdeDataType.Numeric, null, true, true),
        new JdeField("NVYR", "NVYR", JdeDataType.Numeric, null, true, true),
        new JdeField("NVDL01", "NVDL01", JdeDataType.String, 60),
        new JdeField("NVIX01", "NVIX01", JdeDataType.Numeric),
        new JdeField("NVIX02", "NVIX02", JdeDataType.Numeric),
        new JdeField("NVIX03", "NVIX03", JdeDataType.Numeric),
        new JdeField("NVIX04", "NVIX04", JdeDataType.Numeric),
        new JdeField("NVIX05", "NVIX05", JdeDataType.Numeric),
        new JdeField("NVIX06", "NVIX06", JdeDataType.Numeric),
        new JdeField("NVIX07", "NVIX07", JdeDataType.Numeric),
        new JdeField("NVIX08", "NVIX08", JdeDataType.Numeric),
        new JdeField("NVIX09", "NVIX09", JdeDataType.Numeric),
        new JdeField("NVIX10", "NVIX10", JdeDataType.Numeric),
        new JdeField("NVIX11", "NVIX11", JdeDataType.Numeric),
        new JdeField("NVIX12", "NVIX12", JdeDataType.Numeric),
        new JdeField("NVUSER", "NVUSER", JdeDataType.String, 20),
        new JdeField("NVUPMJ", "NVUPMJ", JdeDataType.Numeric),
        new JdeField("NVPID", "NVPID", JdeDataType.String, 20),
        new JdeField("NVJOBN", "NVJOBN", JdeDataType.String, 20),
        new JdeField("NVPJCP", "NVPJCP", JdeDataType.String, 8),
        new JdeField("NVUPMT", "NVUPMT", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F1550_0", "Primary Key on NVINDX, NVCTRY, NVYR", new[] { "NVINDX", "NVCTRY", "NVYR" }, isUnique: true, isPrimaryKey: true)
    };
}
