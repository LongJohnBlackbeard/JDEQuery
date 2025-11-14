using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F7000110 - .
/// </summary>
public class F7000110 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// DALCTR.
        /// </summary>
        public const string DALCTR = "DALCTR";

        /// <summary>
        /// DAK70ADSTR.
        /// </summary>
        public const string DAK70ADSTR = "DAK70ADSTR";

        /// <summary>
        /// DAK70ADOBN.
        /// </summary>
        public const string DAK70ADOBN = "DAK70ADOBN";

        /// <summary>
        /// DADTAI.
        /// </summary>
        public const string DADTAI = "DADTAI";

        /// <summary>
        /// DAK70DTY.
        /// </summary>
        public const string DAK70DTY = "DAK70DTY";

        /// <summary>
        /// DAK70ADPSE.
        /// </summary>
        public const string DAK70ADPSE = "DAK70ADPSE";

        /// <summary>
        /// DAK70ADENA.
        /// </summary>
        public const string DAK70ADENA = "DAK70ADENA";

        /// <summary>
        /// DAK70ADRQR.
        /// </summary>
        public const string DAK70ADRQR = "DAK70ADRQR";

        /// <summary>
        /// DAK70ADDSP.
        /// </summary>
        public const string DAK70ADDSP = "DAK70ADDSP";

        /// <summary>
        /// DAK70ADDPP.
        /// </summary>
        public const string DAK70ADDPP = "DAK70ADDPP";

        /// <summary>
        /// DAK70ADOBR.
        /// </summary>
        public const string DAK70ADOBR = "DAK70ADOBR";

        /// <summary>
        /// DAK70ADAC.
        /// </summary>
        public const string DAK70ADAC = "DAK70ADAC";

        /// <summary>
        /// DAUSER.
        /// </summary>
        public const string DAUSER = "DAUSER";

        /// <summary>
        /// DAPID.
        /// </summary>
        public const string DAPID = "DAPID";

        /// <summary>
        /// DAJOBN.
        /// </summary>
        public const string DAJOBN = "DAJOBN";

        /// <summary>
        /// DAUPMJ.
        /// </summary>
        public const string DAUPMJ = "DAUPMJ";

        /// <summary>
        /// DAUPMT.
        /// </summary>
        public const string DAUPMT = "DAUPMT";
    }

    /// <inheritdoc />
    public override string TableName => "F7000110";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("DALCTR", "DALCTR", JdeDataType.String, 6, true, true),
        new JdeField("DAK70ADSTR", "DAK70ADSTR", JdeDataType.String, 20, true, true),
        new JdeField("DAK70ADOBN", "DAK70ADOBN", JdeDataType.String, 20, true, true),
        new JdeField("DADTAI", "DADTAI", JdeDataType.String, 20, true, true),
        new JdeField("DAK70DTY", "DAK70DTY", JdeDataType.String, 4),
        new JdeField("DAK70ADPSE", "DAK70ADPSE", JdeDataType.Numeric),
        new JdeField("DAK70ADENA", "DAK70ADENA", JdeDataType.String, 2),
        new JdeField("DAK70ADRQR", "DAK70ADRQR", JdeDataType.String, 2),
        new JdeField("DAK70ADDSP", "DAK70ADDSP", JdeDataType.String, 2),
        new JdeField("DAK70ADDPP", "DAK70ADDPP", JdeDataType.Numeric),
        new JdeField("DAK70ADOBR", "DAK70ADOBR", JdeDataType.String, 20),
        new JdeField("DAK70ADAC", "DAK70ADAC", JdeDataType.String, 2),
        new JdeField("DAUSER", "DAUSER", JdeDataType.String, 20),
        new JdeField("DAPID", "DAPID", JdeDataType.String, 20),
        new JdeField("DAJOBN", "DAJOBN", JdeDataType.String, 20),
        new JdeField("DAUPMJ", "DAUPMJ", JdeDataType.Numeric),
        new JdeField("DAUPMT", "DAUPMT", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F7000110_0", "Primary Key on DALCTR, DAK70ADSTR, DAK70ADOBN, DADTAI", new[] { "DALCTR", "DAK70ADSTR", "DAK70ADOBN", "DADTAI" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F7000110_3", "Unique Index on DALCTR, DAK70ADSTR, DAK70ADOBN, DAK70DTY, DAK70ADDPP", new[] { "DALCTR", "DAK70ADSTR", "DAK70ADOBN", "DAK70DTY", "DAK70ADDPP" }, isUnique: true),
        new JdeIndex("F7000110_4", "Unique Index on DALCTR, DAK70ADSTR, DAK70ADOBN, DAK70DTY, DAK70ADPSE", new[] { "DALCTR", "DAK70ADSTR", "DAK70ADOBN", "DAK70DTY", "DAK70ADPSE" }, isUnique: true)
    };
}
