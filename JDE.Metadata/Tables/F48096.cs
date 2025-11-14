using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F48096 - .
/// </summary>
public class F48096 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// WQTKEY.
        /// </summary>
        public const string WQTKEY = "WQTKEY";

        /// <summary>
        /// WQTYKY.
        /// </summary>
        public const string WQTYKY = "WQTYKY";

        /// <summary>
        /// WQEFTB.
        /// </summary>
        public const string WQEFTB = "WQEFTB";

        /// <summary>
        /// WQEFTE.
        /// </summary>
        public const string WQEFTE = "WQEFTE";

        /// <summary>
        /// WQOBJ.
        /// </summary>
        public const string WQOBJ = "WQOBJ";

        /// <summary>
        /// WQOBJT.
        /// </summary>
        public const string WQOBJT = "WQOBJT";

        /// <summary>
        /// WQSUB.
        /// </summary>
        public const string WQSUB = "WQSUB";

        /// <summary>
        /// WQSUBT.
        /// </summary>
        public const string WQSUBT = "WQSUBT";

        /// <summary>
        /// WQJBCD.
        /// </summary>
        public const string WQJBCD = "WQJBCD";

        /// <summary>
        /// WQGTYP.
        /// </summary>
        public const string WQGTYP = "WQGTYP";

        /// <summary>
        /// WQJBST.
        /// </summary>
        public const string WQJBST = "WQJBST";

        /// <summary>
        /// WQPDBA.
        /// </summary>
        public const string WQPDBA = "WQPDBA";

        /// <summary>
        /// WQBRT.
        /// </summary>
        public const string WQBRT = "WQBRT";

        /// <summary>
        /// WQCAP.
        /// </summary>
        public const string WQCAP = "WQCAP";

        /// <summary>
        /// WQPERT.
        /// </summary>
        public const string WQPERT = "WQPERT";

        /// <summary>
        /// WQAA.
        /// </summary>
        public const string WQAA = "WQAA";

        /// <summary>
        /// WQHMCU.
        /// </summary>
        public const string WQHMCU = "WQHMCU";

        /// <summary>
        /// WQRP12.
        /// </summary>
        public const string WQRP12 = "WQRP12";

        /// <summary>
        /// WQAN8.
        /// </summary>
        public const string WQAN8 = "WQAN8";

        /// <summary>
        /// WQNUMB.
        /// </summary>
        public const string WQNUMB = "WQNUMB";

        /// <summary>
        /// WQACL0.
        /// </summary>
        public const string WQACL0 = "WQACL0";

        /// <summary>
        /// WQPRGR.
        /// </summary>
        public const string WQPRGR = "WQPRGR";

        /// <summary>
        /// WQCPGP.
        /// </summary>
        public const string WQCPGP = "WQCPGP";

        /// <summary>
        /// WQBBF.
        /// </summary>
        public const string WQBBF = "WQBBF";

        /// <summary>
        /// WQERC.
        /// </summary>
        public const string WQERC = "WQERC";

        /// <summary>
        /// WQCCR.
        /// </summary>
        public const string WQCCR = "WQCCR";

        /// <summary>
        /// WQCRVR.
        /// </summary>
        public const string WQCRVR = "WQCRVR";

        /// <summary>
        /// WQEXR.
        /// </summary>
        public const string WQEXR = "WQEXR";

        /// <summary>
        /// WQCRCD.
        /// </summary>
        public const string WQCRCD = "WQCRCD";

        /// <summary>
        /// WQCTF1.
        /// </summary>
        public const string WQCTF1 = "WQCTF1";

        /// <summary>
        /// WQCTF2.
        /// </summary>
        public const string WQCTF2 = "WQCTF2";

        /// <summary>
        /// WQUKID.
        /// </summary>
        public const string WQUKID = "WQUKID";

        /// <summary>
        /// WQUSER.
        /// </summary>
        public const string WQUSER = "WQUSER";

        /// <summary>
        /// WQPID.
        /// </summary>
        public const string WQPID = "WQPID";

        /// <summary>
        /// WQJOBN.
        /// </summary>
        public const string WQJOBN = "WQJOBN";

        /// <summary>
        /// WQUPMJ.
        /// </summary>
        public const string WQUPMJ = "WQUPMJ";

        /// <summary>
        /// WQUPMT.
        /// </summary>
        public const string WQUPMT = "WQUPMT";
    }

    /// <inheritdoc />
    public override string TableName => "F48096";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("WQTKEY", "WQTKEY", JdeDataType.String, 24),
        new JdeField("WQTYKY", "WQTYKY", JdeDataType.String, 2),
        new JdeField("WQEFTB", "WQEFTB", JdeDataType.Numeric),
        new JdeField("WQEFTE", "WQEFTE", JdeDataType.Numeric),
        new JdeField("WQOBJ", "WQOBJ", JdeDataType.String, 12),
        new JdeField("WQOBJT", "WQOBJT", JdeDataType.String, 12),
        new JdeField("WQSUB", "WQSUB", JdeDataType.String, 16),
        new JdeField("WQSUBT", "WQSUBT", JdeDataType.String, 16),
        new JdeField("WQJBCD", "WQJBCD", JdeDataType.String, 12),
        new JdeField("WQGTYP", "WQGTYP", JdeDataType.String, 2),
        new JdeField("WQJBST", "WQJBST", JdeDataType.String, 8),
        new JdeField("WQPDBA", "WQPDBA", JdeDataType.Numeric),
        new JdeField("WQBRT", "WQBRT", JdeDataType.Numeric),
        new JdeField("WQCAP", "WQCAP", JdeDataType.String, 2),
        new JdeField("WQPERT", "WQPERT", JdeDataType.Numeric),
        new JdeField("WQAA", "WQAA", JdeDataType.Numeric),
        new JdeField("WQHMCU", "WQHMCU", JdeDataType.String, 24),
        new JdeField("WQRP12", "WQRP12", JdeDataType.String, 6),
        new JdeField("WQAN8", "WQAN8", JdeDataType.Numeric),
        new JdeField("WQNUMB", "WQNUMB", JdeDataType.Numeric),
        new JdeField("WQACL0", "WQACL0", JdeDataType.String, 6),
        new JdeField("WQPRGR", "WQPRGR", JdeDataType.String, 16),
        new JdeField("WQCPGP", "WQCPGP", JdeDataType.String, 16),
        new JdeField("WQBBF", "WQBBF", JdeDataType.String, 2),
        new JdeField("WQERC", "WQERC", JdeDataType.String, 4),
        new JdeField("WQCCR", "WQCCR", JdeDataType.String, 20),
        new JdeField("WQCRVR", "WQCRVR", JdeDataType.String, 20),
        new JdeField("WQEXR", "WQEXR", JdeDataType.String, 60),
        new JdeField("WQCRCD", "WQCRCD", JdeDataType.String, 6),
        new JdeField("WQCTF1", "WQCTF1", JdeDataType.String, 2),
        new JdeField("WQCTF2", "WQCTF2", JdeDataType.String, 2),
        new JdeField("WQUKID", "WQUKID", JdeDataType.Numeric, null, true, true),
        new JdeField("WQUSER", "WQUSER", JdeDataType.String, 20),
        new JdeField("WQPID", "WQPID", JdeDataType.String, 20),
        new JdeField("WQJOBN", "WQJOBN", JdeDataType.String, 20),
        new JdeField("WQUPMJ", "WQUPMJ", JdeDataType.Numeric),
        new JdeField("WQUPMT", "WQUPMT", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F48096_0", "Primary Key on WQUKID", new[] { "WQUKID" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F48096_11", "Index on WQGTYP, WQTYKY, WQTKEY, WQCRCD, WQEFTB, WQOBJ, WQOBJT", new[] { "WQGTYP", "WQTYKY", "WQTKEY", "WQCRCD", "WQEFTB", "WQOBJ", "WQOBJT" }),
        new JdeIndex("F48096_12", "Index on WQCCR, WQCRCD, WQEFTB", new[] { "WQCCR", "WQCRCD", "WQEFTB" }),
        new JdeIndex("F48096_13", "Index on WQCRVR, WQCRCD, WQEFTB", new[] { "WQCRVR", "WQCRCD", "WQEFTB" }),
        new JdeIndex("F48096_2", "Index on WQEFTB", new[] { "WQEFTB" }),
        new JdeIndex("F48096_5", "Index on WQGTYP, WQTYKY, WQTKEY, WQCRCD, WQEFTB, WQJBCD, WQJBST, WQPDBA, WQAN8, WQHMCU, WQRP12, WQOBJT, WQSUBT", new[] { "WQGTYP", "WQTYKY", "WQTKEY", "WQCRCD", "WQEFTB", "WQJBCD", "WQJBST", "WQPDBA", "WQAN8", "WQHMCU", "WQRP12", "WQOBJT", "WQSUBT" }),
        new JdeIndex("F48096_6", "Index on WQGTYP, WQTYKY, WQTKEY, WQCRCD, WQEFTB, WQJBCD, WQJBST, WQPDBA, WQAN8, WQHMCU, WQRP12, WQSUBT, WQOBJT", new[] { "WQGTYP", "WQTYKY", "WQTKEY", "WQCRCD", "WQEFTB", "WQJBCD", "WQJBST", "WQPDBA", "WQAN8", "WQHMCU", "WQRP12", "WQSUBT", "WQOBJT" }),
        new JdeIndex("F48096_7", "Index on WQGTYP, WQTYKY, WQTKEY, WQCRCD, WQEFTB, WQACL0, WQNUMB, WQERC, WQAN8, WQHMCU, WQRP12, WQJBST, WQOBJT, WQSUBT", new[] { "WQGTYP", "WQTYKY", "WQTKEY", "WQCRCD", "WQEFTB", "WQACL0", "WQNUMB", "WQERC", "WQAN8", "WQHMCU", "WQRP12", "WQJBST", "WQOBJT", "WQSUBT" }),
        new JdeIndex("F48096_8", "Index on WQGTYP, WQTYKY, WQTKEY, WQCRCD, WQEFTB, WQACL0, WQNUMB, WQERC, WQAN8, WQHMCU, WQRP12, WQJBST, WQSUBT, WQOBJT", new[] { "WQGTYP", "WQTYKY", "WQTKEY", "WQCRCD", "WQEFTB", "WQACL0", "WQNUMB", "WQERC", "WQAN8", "WQHMCU", "WQRP12", "WQJBST", "WQSUBT", "WQOBJT" }),
        new JdeIndex("F48096_9", "Index on WQGTYP, WQTYKY, WQTKEY, WQCRCD, WQEFTB, WQJBST, WQOBJ, WQOBJT", new[] { "WQGTYP", "WQTYKY", "WQTKEY", "WQCRCD", "WQEFTB", "WQJBST", "WQOBJ", "WQOBJT" })
    };
}
