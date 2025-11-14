using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F09E109 - .
/// </summary>
public class F09E109 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// PCPOLICY.
        /// </summary>
        public const string PCPOLICY = "PCPOLICY";

        /// <summary>
        /// PCEXRPTTYP.
        /// </summary>
        public const string PCEXRPTTYP = "PCEXRPTTYP";

        /// <summary>
        /// PCEXPTYPE.
        /// </summary>
        public const string PCEXPTYPE = "PCEXPTYPE";

        /// <summary>
        /// PCLNID.
        /// </summary>
        public const string PCLNID = "PCLNID";

        /// <summary>
        /// PCEXPDDI.
        /// </summary>
        public const string PCEXPDDI = "PCEXPDDI";

        /// <summary>
        /// PCEXPDBFLD.
        /// </summary>
        public const string PCEXPDBFLD = "PCEXPDBFLD";

        /// <summary>
        /// PCEV01.
        /// </summary>
        public const string PCEV01 = "PCEV01";

        /// <summary>
        /// PCUSER.
        /// </summary>
        public const string PCUSER = "PCUSER";

        /// <summary>
        /// PCPID.
        /// </summary>
        public const string PCPID = "PCPID";

        /// <summary>
        /// PCJOBN.
        /// </summary>
        public const string PCJOBN = "PCJOBN";

        /// <summary>
        /// PCUPMJ.
        /// </summary>
        public const string PCUPMJ = "PCUPMJ";

        /// <summary>
        /// PCUPMT.
        /// </summary>
        public const string PCUPMT = "PCUPMT";
    }

    /// <inheritdoc />
    public override string TableName => "F09E109";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("PCPOLICY", "PCPOLICY", JdeDataType.String, 10, true, true),
        new JdeField("PCEXRPTTYP", "PCEXRPTTYP", JdeDataType.String, 2, true, true),
        new JdeField("PCEXPTYPE", "PCEXPTYPE", JdeDataType.String, 8, true, true),
        new JdeField("PCLNID", "PCLNID", JdeDataType.Numeric, null, true, true),
        new JdeField("PCEXPDDI", "PCEXPDDI", JdeDataType.String, 20),
        new JdeField("PCEXPDBFLD", "PCEXPDBFLD", JdeDataType.String, 20),
        new JdeField("PCEV01", "PCEV01", JdeDataType.String, 2),
        new JdeField("PCUSER", "PCUSER", JdeDataType.String, 20),
        new JdeField("PCPID", "PCPID", JdeDataType.String, 20),
        new JdeField("PCJOBN", "PCJOBN", JdeDataType.String, 20),
        new JdeField("PCUPMJ", "PCUPMJ", JdeDataType.Numeric),
        new JdeField("PCUPMT", "PCUPMT", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F09E109_0", "Primary Key on PCPOLICY, PCEXRPTTYP, PCEXPTYPE, PCLNID", new[] { "PCPOLICY", "PCEXRPTTYP", "PCEXPTYPE", "PCLNID" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F09E109_3", "Index on PCPOLICY, PCEXPTYPE, PCLNID", new[] { "PCPOLICY", "PCEXPTYPE", "PCLNID" })
    };
}
