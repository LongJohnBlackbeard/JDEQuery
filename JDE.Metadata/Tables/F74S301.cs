using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F74S301 - .
/// </summary>
public class F74S301 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// RDUKID.
        /// </summary>
        public const string RDUKID = "RDUKID";

        /// <summary>
        /// RDS74IDNT.
        /// </summary>
        public const string RDS74IDNT = "RDS74IDNT";

        /// <summary>
        /// RDS74NIF.
        /// </summary>
        public const string RDS74NIF = "RDS74NIF";

        /// <summary>
        /// RDS74RCID.
        /// </summary>
        public const string RDS74RCID = "RDS74RCID";

        /// <summary>
        /// RDCO.
        /// </summary>
        public const string RDCO = "RDCO";

        /// <summary>
        /// RDDCT.
        /// </summary>
        public const string RDDCT = "RDDCT";

        /// <summary>
        /// RDDOCO.
        /// </summary>
        public const string RDDOCO = "RDDOCO";

        /// <summary>
        /// RDS74TRNIF.
        /// </summary>
        public const string RDS74TRNIF = "RDS74TRNIF";

        /// <summary>
        /// RDIVD.
        /// </summary>
        public const string RDIVD = "RDIVD";

        /// <summary>
        /// RDS74ERST.
        /// </summary>
        public const string RDS74ERST = "RDS74ERST";

        /// <summary>
        /// RDS74ERCD.
        /// </summary>
        public const string RDS74ERCD = "RDS74ERCD";

        /// <summary>
        /// RDS74ERDC.
        /// </summary>
        public const string RDS74ERDC = "RDS74ERDC";

        /// <summary>
        /// RDS74CSV.
        /// </summary>
        public const string RDS74CSV = "RDS74CSV";

        /// <summary>
        /// RDUSER.
        /// </summary>
        public const string RDUSER = "RDUSER";

        /// <summary>
        /// RDPID.
        /// </summary>
        public const string RDPID = "RDPID";

        /// <summary>
        /// RDJOBN.
        /// </summary>
        public const string RDJOBN = "RDJOBN";

        /// <summary>
        /// RDUPMJ.
        /// </summary>
        public const string RDUPMJ = "RDUPMJ";

        /// <summary>
        /// RDUPMT.
        /// </summary>
        public const string RDUPMT = "RDUPMT";

        /// <summary>
        /// RDS74FUT01.
        /// </summary>
        public const string RDS74FUT01 = "RDS74FUT01";

        /// <summary>
        /// RDS74FUT02.
        /// </summary>
        public const string RDS74FUT02 = "RDS74FUT02";

        /// <summary>
        /// RDS74FUT03.
        /// </summary>
        public const string RDS74FUT03 = "RDS74FUT03";

        /// <summary>
        /// RDS74FUT04.
        /// </summary>
        public const string RDS74FUT04 = "RDS74FUT04";

        /// <summary>
        /// RDS74FUT05.
        /// </summary>
        public const string RDS74FUT05 = "RDS74FUT05";

        /// <summary>
        /// RDS740100.
        /// </summary>
        public const string RDS740100 = "RDS740100";

        /// <summary>
        /// RDK70NUMB.
        /// </summary>
        public const string RDK70NUMB = "RDK70NUMB";

        /// <summary>
        /// RDS74VINV.
        /// </summary>
        public const string RDS74VINV = "RDS74VINV";

        /// <summary>
        /// RDDL01.
        /// </summary>
        public const string RDDL01 = "RDDL01";

        /// <summary>
        /// RDTX2.
        /// </summary>
        public const string RDTX2 = "RDTX2";

        /// <summary>
        /// RDAN8.
        /// </summary>
        public const string RDAN8 = "RDAN8";
    }

    /// <inheritdoc />
    public override string TableName => "F74S301";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("RDUKID", "RDUKID", JdeDataType.Numeric, null, true, true),
        new JdeField("RDS74IDNT", "RDS74IDNT", JdeDataType.String, 8, true, true),
        new JdeField("RDS74NIF", "RDS74NIF", JdeDataType.String, 18, true, true),
        new JdeField("RDS74RCID", "RDS74RCID", JdeDataType.Numeric, null, true, true),
        new JdeField("RDCO", "RDCO", JdeDataType.String, 10),
        new JdeField("RDDCT", "RDDCT", JdeDataType.String, 4),
        new JdeField("RDDOCO", "RDDOCO", JdeDataType.Numeric),
        new JdeField("RDS74TRNIF", "RDS74TRNIF", JdeDataType.String, 18),
        new JdeField("RDIVD", "RDIVD", JdeDataType.Numeric),
        new JdeField("RDS74ERST", "RDS74ERST", JdeDataType.String, 40),
        new JdeField("RDS74ERCD", "RDS74ERCD", JdeDataType.String, 10),
        new JdeField("RDS74ERDC", "RDS74ERDC", JdeDataType.String, 1000),
        new JdeField("RDS74CSV", "RDS74CSV", JdeDataType.String, 60),
        new JdeField("RDUSER", "RDUSER", JdeDataType.String, 20),
        new JdeField("RDPID", "RDPID", JdeDataType.String, 20),
        new JdeField("RDJOBN", "RDJOBN", JdeDataType.String, 20),
        new JdeField("RDUPMJ", "RDUPMJ", JdeDataType.Numeric),
        new JdeField("RDUPMT", "RDUPMT", JdeDataType.Numeric),
        new JdeField("RDS74FUT01", "RDS74FUT01", JdeDataType.Numeric),
        new JdeField("RDS74FUT02", "RDS74FUT02", JdeDataType.String, 60),
        new JdeField("RDS74FUT03", "RDS74FUT03", JdeDataType.String, 2),
        new JdeField("RDS74FUT04", "RDS74FUT04", JdeDataType.String, 2),
        new JdeField("RDS74FUT05", "RDS74FUT05", JdeDataType.Numeric),
        new JdeField("RDS740100", "RDS740100", JdeDataType.Numeric),
        new JdeField("RDK70NUMB", "RDK70NUMB", JdeDataType.Numeric),
        new JdeField("RDS74VINV", "RDS74VINV", JdeDataType.String, 120),
        new JdeField("RDDL01", "RDDL01", JdeDataType.String, 60),
        new JdeField("RDTX2", "RDTX2", JdeDataType.String, 40),
        new JdeField("RDAN8", "RDAN8", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F74S301_0", "Primary Key on RDUKID, RDS74IDNT, RDS74NIF, RDS74RCID", new[] { "RDUKID", "RDS74IDNT", "RDS74NIF", "RDS74RCID" }, isUnique: true, isPrimaryKey: true)
    };
}
