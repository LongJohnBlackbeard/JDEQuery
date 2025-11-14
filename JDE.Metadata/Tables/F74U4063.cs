using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F74U4063 - .
/// </summary>
public class F74U4063 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// AMU74VER.
        /// </summary>
        public const string AMU74VER = "AMU74VER";

        /// <summary>
        /// AMU74DES.
        /// </summary>
        public const string AMU74DES = "AMU74DES";

        /// <summary>
        /// AMU74ICR.
        /// </summary>
        public const string AMU74ICR = "AMU74ICR";

        /// <summary>
        /// AMU74LAN8.
        /// </summary>
        public const string AMU74LAN8 = "AMU74LAN8";

        /// <summary>
        /// AMKCO.
        /// </summary>
        public const string AMKCO = "AMKCO";

        /// <summary>
        /// AMDCT.
        /// </summary>
        public const string AMDCT = "AMDCT";

        /// <summary>
        /// AMDOC.
        /// </summary>
        public const string AMDOC = "AMDOC";

        /// <summary>
        /// AMSFX.
        /// </summary>
        public const string AMSFX = "AMSFX";

        /// <summary>
        /// AMSFXE.
        /// </summary>
        public const string AMSFXE = "AMSFXE";

        /// <summary>
        /// AMDCTM.
        /// </summary>
        public const string AMDCTM = "AMDCTM";

        /// <summary>
        /// AMAG.
        /// </summary>
        public const string AMAG = "AMAG";

        /// <summary>
        /// AMATXA.
        /// </summary>
        public const string AMATXA = "AMATXA";

        /// <summary>
        /// AMATXN.
        /// </summary>
        public const string AMATXN = "AMATXN";

        /// <summary>
        /// AMDMTJ.
        /// </summary>
        public const string AMDMTJ = "AMDMTJ";

        /// <summary>
        /// AMUKTS.
        /// </summary>
        public const string AMUKTS = "AMUKTS";

        /// <summary>
        /// AMUKTAG4.
        /// </summary>
        public const string AMUKTAG4 = "AMUKTAG4";

        /// <summary>
        /// AMUSER.
        /// </summary>
        public const string AMUSER = "AMUSER";

        /// <summary>
        /// AMPID.
        /// </summary>
        public const string AMPID = "AMPID";

        /// <summary>
        /// AMUPMJ.
        /// </summary>
        public const string AMUPMJ = "AMUPMJ";

        /// <summary>
        /// AMUPMT.
        /// </summary>
        public const string AMUPMT = "AMUPMT";

        /// <summary>
        /// AMJOBN.
        /// </summary>
        public const string AMJOBN = "AMJOBN";
    }

    /// <inheritdoc />
    public override string TableName => "F74U4063";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("AMU74VER", "AMU74VER", JdeDataType.String, 28, true, true),
        new JdeField("AMU74DES", "AMU74DES", JdeDataType.String, 60),
        new JdeField("AMU74ICR", "AMU74ICR", JdeDataType.String, 28, true, true),
        new JdeField("AMU74LAN8", "AMU74LAN8", JdeDataType.Numeric, null, true, true),
        new JdeField("AMKCO", "AMKCO", JdeDataType.String, 10, true, true),
        new JdeField("AMDCT", "AMDCT", JdeDataType.String, 4, true, true),
        new JdeField("AMDOC", "AMDOC", JdeDataType.Numeric, null, true, true),
        new JdeField("AMSFX", "AMSFX", JdeDataType.String, 6, true, true),
        new JdeField("AMSFXE", "AMSFXE", JdeDataType.Numeric, null, true, true),
        new JdeField("AMDCTM", "AMDCTM", JdeDataType.String, 4, true, true),
        new JdeField("AMAG", "AMAG", JdeDataType.Numeric),
        new JdeField("AMATXA", "AMATXA", JdeDataType.Numeric),
        new JdeField("AMATXN", "AMATXN", JdeDataType.Numeric),
        new JdeField("AMDMTJ", "AMDMTJ", JdeDataType.Numeric),
        new JdeField("AMUKTS", "AMUKTS", JdeDataType.String, 2),
        new JdeField("AMUKTAG4", "AMUKTAG4", JdeDataType.String, 20),
        new JdeField("AMUSER", "AMUSER", JdeDataType.String, 20),
        new JdeField("AMPID", "AMPID", JdeDataType.String, 20),
        new JdeField("AMUPMJ", "AMUPMJ", JdeDataType.Numeric),
        new JdeField("AMUPMT", "AMUPMT", JdeDataType.Numeric),
        new JdeField("AMJOBN", "AMJOBN", JdeDataType.String, 20)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F74U4063_0", "Primary Key on AMU74VER, AMU74ICR, AMU74LAN8, AMKCO, AMDCT, AMDOC, AMSFX, AMSFXE, AMDCTM", new[] { "AMU74VER", "AMU74ICR", "AMU74LAN8", "AMKCO", "AMDCT", "AMDOC", "AMSFX", "AMSFXE", "AMDCTM" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F74U4063_2", "Index on AMU74VER", new[] { "AMU74VER" })
    };
}
