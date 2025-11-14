using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F1406 - .
/// </summary>
public class F1406 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// FBGRWPC.
        /// </summary>
        public const string FBGRWPC = "FBGRWPC";

        /// <summary>
        /// FBDL01.
        /// </summary>
        public const string FBDL01 = "FBDL01";

        /// <summary>
        /// FBGRWPT.
        /// </summary>
        public const string FBGRWPT = "FBGRWPT";

        /// <summary>
        /// FBFRCAM01.
        /// </summary>
        public const string FBFRCAM01 = "FBFRCAM01";

        /// <summary>
        /// FBFRCAM02.
        /// </summary>
        public const string FBFRCAM02 = "FBFRCAM02";

        /// <summary>
        /// FBFRCAM03.
        /// </summary>
        public const string FBFRCAM03 = "FBFRCAM03";

        /// <summary>
        /// FBFRCAM04.
        /// </summary>
        public const string FBFRCAM04 = "FBFRCAM04";

        /// <summary>
        /// FBFRCAM05.
        /// </summary>
        public const string FBFRCAM05 = "FBFRCAM05";

        /// <summary>
        /// FBFRCAM06.
        /// </summary>
        public const string FBFRCAM06 = "FBFRCAM06";

        /// <summary>
        /// FBFRCAM07.
        /// </summary>
        public const string FBFRCAM07 = "FBFRCAM07";

        /// <summary>
        /// FBFRCAM08.
        /// </summary>
        public const string FBFRCAM08 = "FBFRCAM08";

        /// <summary>
        /// FBFRCAM09.
        /// </summary>
        public const string FBFRCAM09 = "FBFRCAM09";

        /// <summary>
        /// FBFRCAM10.
        /// </summary>
        public const string FBFRCAM10 = "FBFRCAM10";

        /// <summary>
        /// FBFRCAM11.
        /// </summary>
        public const string FBFRCAM11 = "FBFRCAM11";

        /// <summary>
        /// FBFRCAM12.
        /// </summary>
        public const string FBFRCAM12 = "FBFRCAM12";

        /// <summary>
        /// FBFRCAM13.
        /// </summary>
        public const string FBFRCAM13 = "FBFRCAM13";

        /// <summary>
        /// FBFRCAM14.
        /// </summary>
        public const string FBFRCAM14 = "FBFRCAM14";

        /// <summary>
        /// FBFRCAM15.
        /// </summary>
        public const string FBFRCAM15 = "FBFRCAM15";

        /// <summary>
        /// FBUSER.
        /// </summary>
        public const string FBUSER = "FBUSER";

        /// <summary>
        /// FBPID.
        /// </summary>
        public const string FBPID = "FBPID";

        /// <summary>
        /// FBJOBN.
        /// </summary>
        public const string FBJOBN = "FBJOBN";

        /// <summary>
        /// FBUPMJ.
        /// </summary>
        public const string FBUPMJ = "FBUPMJ";

        /// <summary>
        /// FBUPMT.
        /// </summary>
        public const string FBUPMT = "FBUPMT";
    }

    /// <inheritdoc />
    public override string TableName => "F1406";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("FBGRWPC", "FBGRWPC", JdeDataType.String, 20, true, true),
        new JdeField("FBDL01", "FBDL01", JdeDataType.String, 60),
        new JdeField("FBGRWPT", "FBGRWPT", JdeDataType.String, 20),
        new JdeField("FBFRCAM01", "FBFRCAM01", JdeDataType.Numeric),
        new JdeField("FBFRCAM02", "FBFRCAM02", JdeDataType.Numeric),
        new JdeField("FBFRCAM03", "FBFRCAM03", JdeDataType.Numeric),
        new JdeField("FBFRCAM04", "FBFRCAM04", JdeDataType.Numeric),
        new JdeField("FBFRCAM05", "FBFRCAM05", JdeDataType.Numeric),
        new JdeField("FBFRCAM06", "FBFRCAM06", JdeDataType.Numeric),
        new JdeField("FBFRCAM07", "FBFRCAM07", JdeDataType.Numeric),
        new JdeField("FBFRCAM08", "FBFRCAM08", JdeDataType.Numeric),
        new JdeField("FBFRCAM09", "FBFRCAM09", JdeDataType.Numeric),
        new JdeField("FBFRCAM10", "FBFRCAM10", JdeDataType.Numeric),
        new JdeField("FBFRCAM11", "FBFRCAM11", JdeDataType.Numeric),
        new JdeField("FBFRCAM12", "FBFRCAM12", JdeDataType.Numeric),
        new JdeField("FBFRCAM13", "FBFRCAM13", JdeDataType.Numeric),
        new JdeField("FBFRCAM14", "FBFRCAM14", JdeDataType.Numeric),
        new JdeField("FBFRCAM15", "FBFRCAM15", JdeDataType.Numeric),
        new JdeField("FBUSER", "FBUSER", JdeDataType.String, 20),
        new JdeField("FBPID", "FBPID", JdeDataType.String, 20),
        new JdeField("FBJOBN", "FBJOBN", JdeDataType.String, 20),
        new JdeField("FBUPMJ", "FBUPMJ", JdeDataType.Numeric),
        new JdeField("FBUPMT", "FBUPMT", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F1406_0", "Primary Key on FBGRWPC", new[] { "FBGRWPC" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F1406_2", "Index on FBGRWPC, FBGRWPT", new[] { "FBGRWPC", "FBGRWPT" }),
        new JdeIndex("F1406_3", "Index on FBGRWPT", new[] { "FBGRWPT" })
    };
}
