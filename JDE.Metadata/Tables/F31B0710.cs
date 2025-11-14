using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F31B0710 - .
/// </summary>
public class F31B0710 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// HAEURID.
        /// </summary>
        public const string HAEURID = "HAEURID";

        /// <summary>
        /// HAWISSC.
        /// </summary>
        public const string HAWISSC = "HAWISSC";

        /// <summary>
        /// HAQARESULT.
        /// </summary>
        public const string HAQARESULT = "HAQARESULT";

        /// <summary>
        /// HADSC1.
        /// </summary>
        public const string HADSC1 = "HADSC1";

        /// <summary>
        /// HAHORM.
        /// </summary>
        public const string HAHORM = "HAHORM";

        /// <summary>
        /// HAAMIN.
        /// </summary>
        public const string HAAMIN = "HAAMIN";

        /// <summary>
        /// HAQTRG.
        /// </summary>
        public const string HAQTRG = "HAQTRG";

        /// <summary>
        /// HAAMAX.
        /// </summary>
        public const string HAAMAX = "HAAMAX";

        /// <summary>
        /// HACDEC.
        /// </summary>
        public const string HACDEC = "HACDEC";

        /// <summary>
        /// HANUMT.
        /// </summary>
        public const string HANUMT = "HANUMT";

        /// <summary>
        /// HASY.
        /// </summary>
        public const string HASY = "HASY";

        /// <summary>
        /// HART.
        /// </summary>
        public const string HART = "HART";

        /// <summary>
        /// HAURAB.
        /// </summary>
        public const string HAURAB = "HAURAB";

        /// <summary>
        /// HAURAT.
        /// </summary>
        public const string HAURAT = "HAURAT";

        /// <summary>
        /// HAURCD.
        /// </summary>
        public const string HAURCD = "HAURCD";

        /// <summary>
        /// HAURDT.
        /// </summary>
        public const string HAURDT = "HAURDT";

        /// <summary>
        /// HAURRF.
        /// </summary>
        public const string HAURRF = "HAURRF";

        /// <summary>
        /// HAJOBN.
        /// </summary>
        public const string HAJOBN = "HAJOBN";

        /// <summary>
        /// HAPID.
        /// </summary>
        public const string HAPID = "HAPID";

        /// <summary>
        /// HATDAY.
        /// </summary>
        public const string HATDAY = "HATDAY";

        /// <summary>
        /// HAUPMJ.
        /// </summary>
        public const string HAUPMJ = "HAUPMJ";

        /// <summary>
        /// HAUSER.
        /// </summary>
        public const string HAUSER = "HAUSER";

        /// <summary>
        /// HAWAB.
        /// </summary>
        public const string HAWAB = "HAWAB";

        /// <summary>
        /// HAWCD.
        /// </summary>
        public const string HAWCD = "HAWCD";

        /// <summary>
        /// HAWMDT.
        /// </summary>
        public const string HAWMDT = "HAWMDT";

        /// <summary>
        /// HAWNUM.
        /// </summary>
        public const string HAWNUM = "HAWNUM";

        /// <summary>
        /// HAWRF.
        /// </summary>
        public const string HAWRF = "HAWRF";
    }

    /// <inheritdoc />
    public override string TableName => "F31B0710";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("HAEURID", "HAEURID", JdeDataType.Numeric, null, true, true),
        new JdeField("HAWISSC", "HAWISSC", JdeDataType.String, 12, true, true),
        new JdeField("HAQARESULT", "HAQARESULT", JdeDataType.String, 60, true, true),
        new JdeField("HADSC1", "HADSC1", JdeDataType.String, 60),
        new JdeField("HAHORM", "HAHORM", JdeDataType.String, 2),
        new JdeField("HAAMIN", "HAAMIN", JdeDataType.String, 30),
        new JdeField("HAQTRG", "HAQTRG", JdeDataType.String, 30),
        new JdeField("HAAMAX", "HAAMAX", JdeDataType.String, 30),
        new JdeField("HACDEC", "HACDEC", JdeDataType.String, 2),
        new JdeField("HANUMT", "HANUMT", JdeDataType.String, 2),
        new JdeField("HASY", "HASY", JdeDataType.String, 8),
        new JdeField("HART", "HART", JdeDataType.String, 4),
        new JdeField("HAURAB", "HAURAB", JdeDataType.Numeric),
        new JdeField("HAURAT", "HAURAT", JdeDataType.Numeric),
        new JdeField("HAURCD", "HAURCD", JdeDataType.String, 4),
        new JdeField("HAURDT", "HAURDT", JdeDataType.Numeric),
        new JdeField("HAURRF", "HAURRF", JdeDataType.String, 30),
        new JdeField("HAJOBN", "HAJOBN", JdeDataType.String, 20),
        new JdeField("HAPID", "HAPID", JdeDataType.String, 20),
        new JdeField("HATDAY", "HATDAY", JdeDataType.Numeric),
        new JdeField("HAUPMJ", "HAUPMJ", JdeDataType.Numeric),
        new JdeField("HAUSER", "HAUSER", JdeDataType.String, 20),
        new JdeField("HAWAB", "HAWAB", JdeDataType.Numeric),
        new JdeField("HAWCD", "HAWCD", JdeDataType.String, 6),
        new JdeField("HAWMDT", "HAWMDT", JdeDataType.Numeric),
        new JdeField("HAWNUM", "HAWNUM", JdeDataType.Numeric),
        new JdeField("HAWRF", "HAWRF", JdeDataType.String, 60)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F31B0710_0", "Primary Key on HAEURID, HAWISSC, HAQARESULT", new[] { "HAEURID", "HAWISSC", "HAQARESULT" }, isUnique: true, isPrimaryKey: true)
    };
}
