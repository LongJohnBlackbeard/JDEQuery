using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F76B11 - .
/// </summary>
public class F76B11 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// ABCO.
        /// </summary>
        public const string ABCO = "ABCO";

        /// <summary>
        /// ABDGJ.
        /// </summary>
        public const string ABDGJ = "ABDGJ";

        /// <summary>
        /// ABMCU.
        /// </summary>
        public const string ABMCU = "ABMCU";

        /// <summary>
        /// ABOBJ.
        /// </summary>
        public const string ABOBJ = "ABOBJ";

        /// <summary>
        /// ABSUB.
        /// </summary>
        public const string ABSUB = "ABSUB";

        /// <summary>
        /// ABSBL.
        /// </summary>
        public const string ABSBL = "ABSBL";

        /// <summary>
        /// ABBRVSI.
        /// </summary>
        public const string ABBRVSI = "ABBRVSI";

        /// <summary>
        /// ABCRDB.
        /// </summary>
        public const string ABCRDB = "ABCRDB";

        /// <summary>
        /// ABTDEB.
        /// </summary>
        public const string ABTDEB = "ABTDEB";

        /// <summary>
        /// ABTCRE.
        /// </summary>
        public const string ABTCRE = "ABTCRE";

        /// <summary>
        /// ABANFN.
        /// </summary>
        public const string ABANFN = "ABANFN";

        /// <summary>
        /// ABBRCRDB.
        /// </summary>
        public const string ABBRCRDB = "ABBRCRDB";

        /// <summary>
        /// ABPID.
        /// </summary>
        public const string ABPID = "ABPID";

        /// <summary>
        /// ABUSER.
        /// </summary>
        public const string ABUSER = "ABUSER";

        /// <summary>
        /// ABJOBN.
        /// </summary>
        public const string ABJOBN = "ABJOBN";

        /// <summary>
        /// ABUPMJ.
        /// </summary>
        public const string ABUPMJ = "ABUPMJ";

        /// <summary>
        /// ABUPMT.
        /// </summary>
        public const string ABUPMT = "ABUPMT";
    }

    /// <inheritdoc />
    public override string TableName => "F76B11";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("ABCO", "ABCO", JdeDataType.String, 10, true, true),
        new JdeField("ABDGJ", "ABDGJ", JdeDataType.Numeric, null, true, true),
        new JdeField("ABMCU", "ABMCU", JdeDataType.String, 24, true, true),
        new JdeField("ABOBJ", "ABOBJ", JdeDataType.String, 12, true, true),
        new JdeField("ABSUB", "ABSUB", JdeDataType.String, 16, true, true),
        new JdeField("ABSBL", "ABSBL", JdeDataType.String, 16, true, true),
        new JdeField("ABBRVSI", "ABBRVSI", JdeDataType.Numeric),
        new JdeField("ABCRDB", "ABCRDB", JdeDataType.String, 2),
        new JdeField("ABTDEB", "ABTDEB", JdeDataType.Numeric),
        new JdeField("ABTCRE", "ABTCRE", JdeDataType.Numeric),
        new JdeField("ABANFN", "ABANFN", JdeDataType.Numeric),
        new JdeField("ABBRCRDB", "ABBRCRDB", JdeDataType.String, 2),
        new JdeField("ABPID", "ABPID", JdeDataType.String, 20),
        new JdeField("ABUSER", "ABUSER", JdeDataType.String, 20),
        new JdeField("ABJOBN", "ABJOBN", JdeDataType.String, 20),
        new JdeField("ABUPMJ", "ABUPMJ", JdeDataType.Numeric),
        new JdeField("ABUPMT", "ABUPMT", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F76B11_0", "Primary Key on ABCO, ABDGJ, ABMCU, ABOBJ, ABSUB, ABSBL", new[] { "ABCO", "ABDGJ", "ABMCU", "ABOBJ", "ABSUB", "ABSBL" }, isUnique: true, isPrimaryKey: true)
    };
}
