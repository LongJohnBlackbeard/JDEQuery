using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F75C013 - .
/// </summary>
public class F75C013 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// DEC75RPID.
        /// </summary>
        public const string DEC75RPID = "DEC75RPID";

        /// <summary>
        /// DEC75SAID.
        /// </summary>
        public const string DEC75SAID = "DEC75SAID";

        /// <summary>
        /// DEC75DEID.
        /// </summary>
        public const string DEC75DEID = "DEC75DEID";

        /// <summary>
        /// DEC75HENM.
        /// </summary>
        public const string DEC75HENM = "DEC75HENM";

        /// <summary>
        /// DEC75SANM.
        /// </summary>
        public const string DEC75SANM = "DEC75SANM";

        /// <summary>
        /// DEC75DENM.
        /// </summary>
        public const string DEC75DENM = "DEC75DENM";

        /// <summary>
        /// DEC75XMLMO.
        /// </summary>
        public const string DEC75XMLMO = "DEC75XMLMO";

        /// <summary>
        /// DEC75XMLFV.
        /// </summary>
        public const string DEC75XMLFV = "DEC75XMLFV";

        /// <summary>
        /// DEFUTMATH1.
        /// </summary>
        public const string DEFUTMATH1 = "DEFUTMATH1";

        /// <summary>
        /// DEFUTSTR1.
        /// </summary>
        public const string DEFUTSTR1 = "DEFUTSTR1";

        /// <summary>
        /// DEFUTDATE1.
        /// </summary>
        public const string DEFUTDATE1 = "DEFUTDATE1";

        /// <summary>
        /// DEFUTUO1.
        /// </summary>
        public const string DEFUTUO1 = "DEFUTUO1";

        /// <summary>
        /// DEUSER.
        /// </summary>
        public const string DEUSER = "DEUSER";

        /// <summary>
        /// DEPID.
        /// </summary>
        public const string DEPID = "DEPID";

        /// <summary>
        /// DEJOBN.
        /// </summary>
        public const string DEJOBN = "DEJOBN";

        /// <summary>
        /// DEUPMJ.
        /// </summary>
        public const string DEUPMJ = "DEUPMJ";

        /// <summary>
        /// DEUPMT.
        /// </summary>
        public const string DEUPMT = "DEUPMT";
    }

    /// <inheritdoc />
    public override string TableName => "F75C013";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("DEC75RPID", "DEC75RPID", JdeDataType.Numeric, null, true, true),
        new JdeField("DEC75SAID", "DEC75SAID", JdeDataType.Numeric, null, true, true),
        new JdeField("DEC75DEID", "DEC75DEID", JdeDataType.Numeric, null, true, true),
        new JdeField("DEC75HENM", "DEC75HENM", JdeDataType.String, 60),
        new JdeField("DEC75SANM", "DEC75SANM", JdeDataType.String, 60),
        new JdeField("DEC75DENM", "DEC75DENM", JdeDataType.String, 60),
        new JdeField("DEC75XMLMO", "DEC75XMLMO", JdeDataType.String, 2),
        new JdeField("DEC75XMLFV", "DEC75XMLFV", JdeDataType.String, 2),
        new JdeField("DEFUTMATH1", "DEFUTMATH1", JdeDataType.Numeric),
        new JdeField("DEFUTSTR1", "DEFUTSTR1", JdeDataType.String, 100),
        new JdeField("DEFUTDATE1", "DEFUTDATE1", JdeDataType.Numeric),
        new JdeField("DEFUTUO1", "DEFUTUO1", JdeDataType.String, 2),
        new JdeField("DEUSER", "DEUSER", JdeDataType.String, 20),
        new JdeField("DEPID", "DEPID", JdeDataType.String, 20),
        new JdeField("DEJOBN", "DEJOBN", JdeDataType.String, 20),
        new JdeField("DEUPMJ", "DEUPMJ", JdeDataType.Numeric),
        new JdeField("DEUPMT", "DEUPMT", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F75C013_0", "Primary Key on DEC75RPID, DEC75SAID, DEC75DEID", new[] { "DEC75RPID", "DEC75SAID", "DEC75DEID" }, isUnique: true, isPrimaryKey: true)
    };
}
