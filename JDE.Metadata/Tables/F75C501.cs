using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F75C501 - .
/// </summary>
public class F75C501 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// CEC75PCID.
        /// </summary>
        public const string CEC75PCID = "CEC75PCID";

        /// <summary>
        /// CEC75PEID.
        /// </summary>
        public const string CEC75PEID = "CEC75PEID";

        /// <summary>
        /// CEFUTMATH1.
        /// </summary>
        public const string CEFUTMATH1 = "CEFUTMATH1";

        /// <summary>
        /// CEFUTSTR1.
        /// </summary>
        public const string CEFUTSTR1 = "CEFUTSTR1";

        /// <summary>
        /// CEFUTSTR2.
        /// </summary>
        public const string CEFUTSTR2 = "CEFUTSTR2";

        /// <summary>
        /// CEFUTDATE1.
        /// </summary>
        public const string CEFUTDATE1 = "CEFUTDATE1";

        /// <summary>
        /// CEFUTUO1.
        /// </summary>
        public const string CEFUTUO1 = "CEFUTUO1";

        /// <summary>
        /// CEUSER.
        /// </summary>
        public const string CEUSER = "CEUSER";

        /// <summary>
        /// CEPID.
        /// </summary>
        public const string CEPID = "CEPID";

        /// <summary>
        /// CEJOBN.
        /// </summary>
        public const string CEJOBN = "CEJOBN";

        /// <summary>
        /// CEUPMJ.
        /// </summary>
        public const string CEUPMJ = "CEUPMJ";

        /// <summary>
        /// CEUPMT.
        /// </summary>
        public const string CEUPMT = "CEUPMT";
    }

    /// <inheritdoc />
    public override string TableName => "F75C501";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("CEC75PCID", "CEC75PCID", JdeDataType.Numeric, null, true, true),
        new JdeField("CEC75PEID", "CEC75PEID", JdeDataType.String, 120, true, true),
        new JdeField("CEFUTMATH1", "CEFUTMATH1", JdeDataType.Numeric),
        new JdeField("CEFUTSTR1", "CEFUTSTR1", JdeDataType.String, 100),
        new JdeField("CEFUTSTR2", "CEFUTSTR2", JdeDataType.String, 100),
        new JdeField("CEFUTDATE1", "CEFUTDATE1", JdeDataType.Numeric),
        new JdeField("CEFUTUO1", "CEFUTUO1", JdeDataType.String, 2),
        new JdeField("CEUSER", "CEUSER", JdeDataType.String, 20),
        new JdeField("CEPID", "CEPID", JdeDataType.String, 20),
        new JdeField("CEJOBN", "CEJOBN", JdeDataType.String, 20),
        new JdeField("CEUPMJ", "CEUPMJ", JdeDataType.Numeric),
        new JdeField("CEUPMT", "CEUPMT", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F75C501_0", "Primary Key on CEC75PCID, CEC75PEID", new[] { "CEC75PCID", "CEC75PEID" }, isUnique: true, isPrimaryKey: true)
    };
}
