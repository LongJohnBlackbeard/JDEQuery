using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F4006Z - .
/// </summary>
public class F4006Z : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// OYEDOC.
        /// </summary>
        public const string OYEDOC = "OYEDOC";

        /// <summary>
        /// OYEDCT.
        /// </summary>
        public const string OYEDCT = "OYEDCT";

        /// <summary>
        /// OYEKCO.
        /// </summary>
        public const string OYEKCO = "OYEKCO";

        /// <summary>
        /// OYANTY.
        /// </summary>
        public const string OYANTY = "OYANTY";

        /// <summary>
        /// OYMLNM.
        /// </summary>
        public const string OYMLNM = "OYMLNM";

        /// <summary>
        /// OYADD1.
        /// </summary>
        public const string OYADD1 = "OYADD1";

        /// <summary>
        /// OYADD2.
        /// </summary>
        public const string OYADD2 = "OYADD2";

        /// <summary>
        /// OYADD3.
        /// </summary>
        public const string OYADD3 = "OYADD3";

        /// <summary>
        /// OYADD4.
        /// </summary>
        public const string OYADD4 = "OYADD4";

        /// <summary>
        /// OYADDZ.
        /// </summary>
        public const string OYADDZ = "OYADDZ";

        /// <summary>
        /// OYCTY1.
        /// </summary>
        public const string OYCTY1 = "OYCTY1";

        /// <summary>
        /// OYCOUN.
        /// </summary>
        public const string OYCOUN = "OYCOUN";

        /// <summary>
        /// OYADDS.
        /// </summary>
        public const string OYADDS = "OYADDS";

        /// <summary>
        /// OYCRTE.
        /// </summary>
        public const string OYCRTE = "OYCRTE";

        /// <summary>
        /// OYBKML.
        /// </summary>
        public const string OYBKML = "OYBKML";

        /// <summary>
        /// OYCTR.
        /// </summary>
        public const string OYCTR = "OYCTR";

        /// <summary>
        /// OYUSER.
        /// </summary>
        public const string OYUSER = "OYUSER";

        /// <summary>
        /// OYPID.
        /// </summary>
        public const string OYPID = "OYPID";

        /// <summary>
        /// OYUPMJ.
        /// </summary>
        public const string OYUPMJ = "OYUPMJ";

        /// <summary>
        /// OYJOBN.
        /// </summary>
        public const string OYJOBN = "OYJOBN";

        /// <summary>
        /// OYUPMT.
        /// </summary>
        public const string OYUPMT = "OYUPMT";
    }

    /// <inheritdoc />
    public override string TableName => "F4006Z";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("OYEDOC", "OYEDOC", JdeDataType.Numeric, null, true, true),
        new JdeField("OYEDCT", "OYEDCT", JdeDataType.String, 4, true, true),
        new JdeField("OYEKCO", "OYEKCO", JdeDataType.String, 10, true, true),
        new JdeField("OYANTY", "OYANTY", JdeDataType.String, 2, true, true),
        new JdeField("OYMLNM", "OYMLNM", JdeDataType.String, 80),
        new JdeField("OYADD1", "OYADD1", JdeDataType.String, 80),
        new JdeField("OYADD2", "OYADD2", JdeDataType.String, 80),
        new JdeField("OYADD3", "OYADD3", JdeDataType.String, 80),
        new JdeField("OYADD4", "OYADD4", JdeDataType.String, 80),
        new JdeField("OYADDZ", "OYADDZ", JdeDataType.String, 24),
        new JdeField("OYCTY1", "OYCTY1", JdeDataType.String, 50),
        new JdeField("OYCOUN", "OYCOUN", JdeDataType.String, 50),
        new JdeField("OYADDS", "OYADDS", JdeDataType.String, 6),
        new JdeField("OYCRTE", "OYCRTE", JdeDataType.String, 8),
        new JdeField("OYBKML", "OYBKML", JdeDataType.String, 4),
        new JdeField("OYCTR", "OYCTR", JdeDataType.String, 6),
        new JdeField("OYUSER", "OYUSER", JdeDataType.String, 20),
        new JdeField("OYPID", "OYPID", JdeDataType.String, 20),
        new JdeField("OYUPMJ", "OYUPMJ", JdeDataType.Numeric),
        new JdeField("OYJOBN", "OYJOBN", JdeDataType.String, 20),
        new JdeField("OYUPMT", "OYUPMT", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F4006Z_0", "Primary Key on OYEDOC, OYEDCT, OYEKCO, OYANTY", new[] { "OYEDOC", "OYEDCT", "OYEKCO", "OYANTY" }, isPrimaryKey: true)
    };
}
