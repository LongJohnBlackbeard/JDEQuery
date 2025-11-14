using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F49025 - .
/// </summary>
public class F49025 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// CVCVID.
        /// </summary>
        public const string CVCVID = "CVCVID";

        /// <summary>
        /// CVMCU.
        /// </summary>
        public const string CVMCU = "CVMCU";

        /// <summary>
        /// CVOSEQ.
        /// </summary>
        public const string CVOSEQ = "CVOSEQ";

        /// <summary>
        /// CVWTUM.
        /// </summary>
        public const string CVWTUM = "CVWTUM";

        /// <summary>
        /// CVVLUM.
        /// </summary>
        public const string CVVLUM = "CVVLUM";

        /// <summary>
        /// CVDL01.
        /// </summary>
        public const string CVDL01 = "CVDL01";

        /// <summary>
        /// CVEFTJ.
        /// </summary>
        public const string CVEFTJ = "CVEFTJ";

        /// <summary>
        /// CVEXDJ.
        /// </summary>
        public const string CVEXDJ = "CVEXDJ";

        /// <summary>
        /// CVVEHI.
        /// </summary>
        public const string CVVEHI = "CVVEHI";

        /// <summary>
        /// CVDUMV.
        /// </summary>
        public const string CVDUMV = "CVDUMV";

        /// <summary>
        /// CVVEHT.
        /// </summary>
        public const string CVVEHT = "CVVEHT";

        /// <summary>
        /// CVTMVT.
        /// </summary>
        public const string CVTMVT = "CVTMVT";

        /// <summary>
        /// CVRLNO.
        /// </summary>
        public const string CVRLNO = "CVRLNO";

        /// <summary>
        /// CVUSER.
        /// </summary>
        public const string CVUSER = "CVUSER";

        /// <summary>
        /// CVPID.
        /// </summary>
        public const string CVPID = "CVPID";

        /// <summary>
        /// CVJOBN.
        /// </summary>
        public const string CVJOBN = "CVJOBN";

        /// <summary>
        /// CVUPMJ.
        /// </summary>
        public const string CVUPMJ = "CVUPMJ";

        /// <summary>
        /// CVTDAY.
        /// </summary>
        public const string CVTDAY = "CVTDAY";
    }

    /// <inheritdoc />
    public override string TableName => "F49025";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("CVCVID", "CVCVID", JdeDataType.String, 24, true, true),
        new JdeField("CVMCU", "CVMCU", JdeDataType.String, 24),
        new JdeField("CVOSEQ", "CVOSEQ", JdeDataType.Numeric, null, true, true),
        new JdeField("CVWTUM", "CVWTUM", JdeDataType.String, 4),
        new JdeField("CVVLUM", "CVVLUM", JdeDataType.String, 4),
        new JdeField("CVDL01", "CVDL01", JdeDataType.String, 60),
        new JdeField("CVEFTJ", "CVEFTJ", JdeDataType.Numeric, null, true, true),
        new JdeField("CVEXDJ", "CVEXDJ", JdeDataType.Numeric),
        new JdeField("CVVEHI", "CVVEHI", JdeDataType.String, 24, true, true),
        new JdeField("CVDUMV", "CVDUMV", JdeDataType.String, 2),
        new JdeField("CVVEHT", "CVVEHT", JdeDataType.String, 6),
        new JdeField("CVTMVT", "CVTMVT", JdeDataType.String, 2),
        new JdeField("CVRLNO", "CVRLNO", JdeDataType.String, 26),
        new JdeField("CVUSER", "CVUSER", JdeDataType.String, 20),
        new JdeField("CVPID", "CVPID", JdeDataType.String, 20),
        new JdeField("CVJOBN", "CVJOBN", JdeDataType.String, 20),
        new JdeField("CVUPMJ", "CVUPMJ", JdeDataType.Numeric),
        new JdeField("CVTDAY", "CVTDAY", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F49025_0", "Primary Key on CVCVID, CVOSEQ, CVVEHI, CVEFTJ", new[] { "CVCVID", "CVOSEQ", "CVVEHI", "CVEFTJ" }, isUnique: true, isPrimaryKey: true)
    };
}
